using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

using MDI_Interface.CustomDataTypes.Enums;
using MDI_Interface.UserCtrl;
using MDI_Interface.ViewModels;
using MDI_Interface.CustomDataTypes.Structs;

namespace MDI_Interface
{
    public partial class Form1 : Form
    {

        MDICommandManager manager;

        private List<MDIButtonData> mdiButtonDataList = new List<MDIButtonData>();

        public Form1()
        {
            InitializeComponent();

            manager = new MDICommandManager();
            
            Setup();

            // Get the backgroundworker running for updating the state of the LEDs above the individual buttons
            backgroundWorkerUpdate.RunWorkerAsync();
        }

        public void Setup()
        {
            // Get button names
            LoadButtonData();

            // Set the names of the buttons
            int mdiCommandCount = Enum.GetNames(typeof(MDICommand)).Length;

            for (int i = 0; i < mdiCommandCount; i++)
            {

                MDICommand command = (MDICommand)i;

                string ctrlName = "ctrl" + command.ToString();
                var control = this.Controls.OfType<CtrlButtonLed>().FirstOrDefault(c => c.Name == ctrlName);
                control.SetButtonName = mdiButtonDataList[i].name;
                // Event handler is required to access the button onClick function in the user control
                control.btnOnClick += new EventHandler(btn_onClick);

            }
        }

        // Background Worker used for executing the command given by the buttons
        private void backgroundWorkerCommand_DoWork(object sender, DoWorkEventArgs e)
        {
            ushort handle = manager.DeviceManager.Connect();
            manager.SetCommand(handle, (MDICommand)e.Argument);
            manager.DeviceManager.Disconnect(handle);
        }

        // Background worker used for updating the Textbox LED!
        private void backgroundWorkerUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            // With this implementation the handle can not be freed, but this should be no problem 
            // as CNC frees the handle on its own after +/- 20 seconds, if it is not used

            ushort handle = manager.DeviceManager.Connect();
            int mdiCommandCount = Enum.GetNames(typeof(MDICommand)).Length;

            while (true)
            {
                for (int i = 0; i < mdiCommandCount; i++)
                {

                    MDICommand command = (MDICommand)i;
                    bool check = manager.GetCommand(handle, command);

                    string ctrlName = "ctrl" + command.ToString();
                    var control = this.Controls.OfType<CtrlButtonLed>().FirstOrDefault(c => c.Name == ctrlName);


                    // Get access to front-end function with background worker thread
                    if (check)
                    {
                        control.Invoke((MethodInvoker)delegate
                        {
                            control.ChangeLblBackgroundColor = Color.Yellow;
                        });
                    }
                    else
                    {
                        control.Invoke((MethodInvoker)delegate
                        {
                            control.ChangeLblBackgroundColor = Color.White;
                        });
                    }
                }
                Thread.Sleep(10);
            }
        }

        void btn_onClick(object sender, EventArgs e)
        {

            if (!backgroundWorkerCommand.IsBusy)
            {
                // Get the name of the user control in which the calling button is located
                Control control = (Button)sender;
                control = control.Parent;
                string ControlName = ((CtrlButtonLed)control).Name;
                string strCommand = ControlName.Substring(4, ControlName.Length - 4); // remove ctrl form the name
                MDICommand command = (MDICommand)Enum.Parse(typeof(MDICommand), strCommand, false); // casting to enum

                backgroundWorkerCommand.RunWorkerAsync(command);
            }
        }

        public void LoadButtonData()
        {
            // Code strongly inspired from http://csharp.net-informations.com/excel/csharp-read-excel.htm
            
            // Init of the Excel stuff
            Excel.Application excelApp;
            Excel.Worksheet excelWorkSheet;
            Excel.Range excelRange;

            // Open excel sheet, works only with absolute path apparently
            excelApp = new Excel.Application();
            string exeDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(Path.Combine(exeDir, "Data/ButtonDescriptions.xlsx"));

            excelWorkSheet = (Excel.Worksheet)excelWorkbook.Worksheets.get_Item(1);

            excelRange = excelWorkSheet.UsedRange;
            int numberOfCommands = excelRange.Rows.Count;

            for (int i = 2; i <= numberOfCommands; i++)
            {
                MDIButtonData mdiButtonData = new MDIButtonData();
                mdiButtonData.command = (MDICommand)Enum.Parse(typeof(MDICommand), (excelRange.Cells[i, 1] as Excel.Range).Value2.ToString());
                mdiButtonData.name = (excelRange.Cells[i, 2] as Excel.Range).Value2.ToString();

                mdiButtonDataList.Add(mdiButtonData);
            }

            excelWorkbook.Close(true, null, null);
            excelApp.Quit();

            // Properly close all the excel stuff
            Marshal.ReleaseComObject(excelWorkSheet);
            Marshal.ReleaseComObject(excelWorkbook);
            Marshal.ReleaseComObject(excelApp);

            // rearrange buttonData list in the right order of the MDICommand enum
            StructListManipulator manipulator = new StructListManipulator();
            mdiButtonDataList = manipulator.RearrangeStructList(mdiButtonDataList);

        }
    }
}
