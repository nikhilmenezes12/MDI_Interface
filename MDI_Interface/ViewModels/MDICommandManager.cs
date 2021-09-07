using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

using MDI_Interface.Models;
using MDI_Interface.CustomDataTypes.Enums;
using MDI_Interface.CustomDataTypes.Structs;

namespace MDI_Interface.ViewModels
{
    class MDICommandManager
    {
        private List<MDICommandData> mdiCommandDataList = new List<MDICommandData>();

        DeviceManager deviceManager = new DeviceManager();

        public MDICommandManager()
        {
            LoadMdiCommandData();
        }

        public DeviceManager DeviceManager
        {
            get
            {
                return deviceManager;
            }
        }

        public void SetCommand(ushort handle, MDICommand command) {
            deviceManager.UpdateAddress(handle, mdiCommandDataList[(int)command].inputAddress, mdiCommandDataList[(int)command].inputBit);
        }

        public bool GetCommand(ushort handle, MDICommand command) {
            return deviceManager.ReadAddress(handle, mdiCommandDataList[(int)command].outputAddress, mdiCommandDataList[(int)command].outputBit);
        }

        private (short, short) ProcessAddress(string compressedAddress)
        {
            short inputAddress, inputBitCode;
            int pointposition = compressedAddress.IndexOf(".");
            inputAddress = (short)Int32.Parse(compressedAddress.Substring(0, pointposition));
            inputBitCode = (short)Int32.Parse(compressedAddress.Substring(pointposition + 1));
            return (inputAddress, inputBitCode);
        }

        public void LoadMdiCommandData()
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
                MDICommandData mdiCommandData = new MDICommandData();
                mdiCommandData.command = (MDICommand)Enum.Parse(typeof(MDICommand), (excelRange.Cells[i, 1] as Excel.Range).Value2.ToString());
                (mdiCommandData.inputAddress, mdiCommandData.inputBit) = ((short, short))ProcessAddress((excelRange.Cells[i, 3] as Excel.Range).Value2.ToString());
                (mdiCommandData.outputAddress, mdiCommandData.outputBit) = ((short, short))ProcessAddress((excelRange.Cells[i, 4] as Excel.Range).Value2.ToString());
                mdiCommandDataList.Add(mdiCommandData);
            }

            excelWorkbook.Close(true, null, null);
            excelApp.Quit();

            // Properly close all the excel stuff
            Marshal.ReleaseComObject(excelWorkSheet);
            Marshal.ReleaseComObject(excelWorkbook);
            Marshal.ReleaseComObject(excelApp);

            // rearrange buttonData list in the right order of the MDICommand enum
            StructListManipulator manipulator = new StructListManipulator();
            mdiCommandDataList = manipulator.RearrangeStructList(mdiCommandDataList);

        }
    }
}
