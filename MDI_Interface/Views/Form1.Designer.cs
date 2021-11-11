
namespace MDI_Interface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorkerCommand = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerUpdate = new System.ComponentModel.BackgroundWorker();
            this.ctrlPMCAXISON = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlPathMinus = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlPathPlus = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlPSynch = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlX1000 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlX100 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlX10 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlX1 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlRestart = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlCycleStart = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlCycleStop = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlMinus = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlPlus = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlAxis8 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlAxis7 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlAxis6 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlAxis5 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlAxis4 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlZ = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlY = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlX = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlHandle = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlInc = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlJog = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlRef = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlRemote = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlMdi = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlEdit = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlAuto = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlRecoaterRollerOn = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlRecoaterRollerOff = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.SuspendLayout();
            // 
            // backgroundWorkerCommand
            // 
            this.backgroundWorkerCommand.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCommand_DoWork);
            // 
            // backgroundWorkerUpdate
            // 
            this.backgroundWorkerUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUpdate_DoWork);
            // 
            // ctrlPMCAXISON
            // 
            this.ctrlPMCAXISON.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlPMCAXISON.Location = new System.Drawing.Point(511, 411);
            this.ctrlPMCAXISON.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPMCAXISON.Name = "ctrlPMCAXISON";
            this.ctrlPMCAXISON.Size = new System.Drawing.Size(85, 91);
            this.ctrlPMCAXISON.TabIndex = 29;
            this.ctrlPMCAXISON.Load += new System.EventHandler(this.ctrlPMCAXISON_Load_1);
            // 
            // ctrlPathMinus
            // 
            this.ctrlPathMinus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlPathMinus.Location = new System.Drawing.Point(911, 212);
            this.ctrlPathMinus.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPathMinus.Name = "ctrlPathMinus";
            this.ctrlPathMinus.Size = new System.Drawing.Size(85, 91);
            this.ctrlPathMinus.TabIndex = 28;
            // 
            // ctrlPathPlus
            // 
            this.ctrlPathPlus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlPathPlus.Location = new System.Drawing.Point(911, 113);
            this.ctrlPathPlus.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPathPlus.Name = "ctrlPathPlus";
            this.ctrlPathPlus.Size = new System.Drawing.Size(85, 91);
            this.ctrlPathPlus.TabIndex = 27;
            // 
            // ctrlPSynch
            // 
            this.ctrlPSynch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlPSynch.Location = new System.Drawing.Point(911, 15);
            this.ctrlPSynch.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPSynch.Name = "ctrlPSynch";
            this.ctrlPSynch.Size = new System.Drawing.Size(85, 91);
            this.ctrlPSynch.TabIndex = 26;
            // 
            // ctrlX1000
            // 
            this.ctrlX1000.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlX1000.Location = new System.Drawing.Point(296, 310);
            this.ctrlX1000.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlX1000.Name = "ctrlX1000";
            this.ctrlX1000.Size = new System.Drawing.Size(85, 91);
            this.ctrlX1000.TabIndex = 25;
            // 
            // ctrlX100
            // 
            this.ctrlX100.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlX100.Location = new System.Drawing.Point(203, 310);
            this.ctrlX100.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlX100.Name = "ctrlX100";
            this.ctrlX100.Size = new System.Drawing.Size(85, 91);
            this.ctrlX100.TabIndex = 24;
            // 
            // ctrlX10
            // 
            this.ctrlX10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlX10.Location = new System.Drawing.Point(109, 310);
            this.ctrlX10.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlX10.Name = "ctrlX10";
            this.ctrlX10.Size = new System.Drawing.Size(85, 91);
            this.ctrlX10.TabIndex = 23;
            // 
            // ctrlX1
            // 
            this.ctrlX1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlX1.Location = new System.Drawing.Point(16, 310);
            this.ctrlX1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlX1.Name = "ctrlX1";
            this.ctrlX1.Size = new System.Drawing.Size(85, 91);
            this.ctrlX1.TabIndex = 22;
            // 
            // ctrlRestart
            // 
            this.ctrlRestart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlRestart.Location = new System.Drawing.Point(203, 409);
            this.ctrlRestart.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlRestart.Name = "ctrlRestart";
            this.ctrlRestart.Size = new System.Drawing.Size(85, 91);
            this.ctrlRestart.TabIndex = 21;
            // 
            // ctrlCycleStart
            // 
            this.ctrlCycleStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlCycleStart.Location = new System.Drawing.Point(109, 409);
            this.ctrlCycleStart.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlCycleStart.Name = "ctrlCycleStart";
            this.ctrlCycleStart.Size = new System.Drawing.Size(85, 91);
            this.ctrlCycleStart.TabIndex = 20;
            // 
            // ctrlCycleStop
            // 
            this.ctrlCycleStop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlCycleStop.Location = new System.Drawing.Point(16, 409);
            this.ctrlCycleStop.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlCycleStop.Name = "ctrlCycleStop";
            this.ctrlCycleStop.Size = new System.Drawing.Size(85, 91);
            this.ctrlCycleStop.TabIndex = 19;
            // 
            // ctrlMinus
            // 
            this.ctrlMinus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlMinus.Location = new System.Drawing.Point(697, 310);
            this.ctrlMinus.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlMinus.Name = "ctrlMinus";
            this.ctrlMinus.Size = new System.Drawing.Size(85, 91);
            this.ctrlMinus.TabIndex = 18;
            this.ctrlMinus.Load += new System.EventHandler(this.ctrlMinus_Load);
            // 
            // ctrlPlus
            // 
            this.ctrlPlus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlPlus.Location = new System.Drawing.Point(511, 310);
            this.ctrlPlus.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPlus.Name = "ctrlPlus";
            this.ctrlPlus.Size = new System.Drawing.Size(85, 91);
            this.ctrlPlus.TabIndex = 17;
            this.ctrlPlus.Load += new System.EventHandler(this.ctrlPlus_Load);
            // 
            // ctrlAxis8
            // 
            this.ctrlAxis8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlAxis8.Location = new System.Drawing.Point(604, 212);
            this.ctrlAxis8.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlAxis8.Name = "ctrlAxis8";
            this.ctrlAxis8.Size = new System.Drawing.Size(85, 91);
            this.ctrlAxis8.TabIndex = 15;
            // 
            // ctrlAxis7
            // 
            this.ctrlAxis7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlAxis7.Location = new System.Drawing.Point(511, 212);
            this.ctrlAxis7.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlAxis7.Name = "ctrlAxis7";
            this.ctrlAxis7.Size = new System.Drawing.Size(85, 91);
            this.ctrlAxis7.TabIndex = 14;
            // 
            // ctrlAxis6
            // 
            this.ctrlAxis6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlAxis6.Location = new System.Drawing.Point(697, 113);
            this.ctrlAxis6.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlAxis6.Name = "ctrlAxis6";
            this.ctrlAxis6.Size = new System.Drawing.Size(85, 91);
            this.ctrlAxis6.TabIndex = 13;
            // 
            // ctrlAxis5
            // 
            this.ctrlAxis5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlAxis5.Location = new System.Drawing.Point(604, 113);
            this.ctrlAxis5.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlAxis5.Name = "ctrlAxis5";
            this.ctrlAxis5.Size = new System.Drawing.Size(85, 91);
            this.ctrlAxis5.TabIndex = 12;
            // 
            // ctrlAxis4
            // 
            this.ctrlAxis4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlAxis4.Location = new System.Drawing.Point(511, 113);
            this.ctrlAxis4.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlAxis4.Name = "ctrlAxis4";
            this.ctrlAxis4.Size = new System.Drawing.Size(85, 91);
            this.ctrlAxis4.TabIndex = 11;
            // 
            // ctrlZ
            // 
            this.ctrlZ.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlZ.Location = new System.Drawing.Point(697, 15);
            this.ctrlZ.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlZ.Name = "ctrlZ";
            this.ctrlZ.Size = new System.Drawing.Size(85, 91);
            this.ctrlZ.TabIndex = 10;
            // 
            // ctrlY
            // 
            this.ctrlY.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlY.Location = new System.Drawing.Point(604, 15);
            this.ctrlY.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlY.Name = "ctrlY";
            this.ctrlY.Size = new System.Drawing.Size(85, 91);
            this.ctrlY.TabIndex = 9;
            // 
            // ctrlX
            // 
            this.ctrlX.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlX.Location = new System.Drawing.Point(511, 15);
            this.ctrlX.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlX.Name = "ctrlX";
            this.ctrlX.Size = new System.Drawing.Size(85, 91);
            this.ctrlX.TabIndex = 8;
            // 
            // ctrlHandle
            // 
            this.ctrlHandle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlHandle.Location = new System.Drawing.Point(296, 113);
            this.ctrlHandle.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlHandle.Name = "ctrlHandle";
            this.ctrlHandle.Size = new System.Drawing.Size(85, 91);
            this.ctrlHandle.TabIndex = 7;
            // 
            // ctrlInc
            // 
            this.ctrlInc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlInc.Location = new System.Drawing.Point(203, 113);
            this.ctrlInc.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlInc.Name = "ctrlInc";
            this.ctrlInc.Size = new System.Drawing.Size(85, 91);
            this.ctrlInc.TabIndex = 6;
            // 
            // ctrlJog
            // 
            this.ctrlJog.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlJog.Location = new System.Drawing.Point(109, 113);
            this.ctrlJog.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlJog.Name = "ctrlJog";
            this.ctrlJog.Size = new System.Drawing.Size(85, 91);
            this.ctrlJog.TabIndex = 5;
            // 
            // ctrlRef
            // 
            this.ctrlRef.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlRef.Location = new System.Drawing.Point(16, 113);
            this.ctrlRef.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlRef.Name = "ctrlRef";
            this.ctrlRef.Size = new System.Drawing.Size(85, 91);
            this.ctrlRef.TabIndex = 4;
            // 
            // ctrlRemote
            // 
            this.ctrlRemote.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlRemote.Location = new System.Drawing.Point(296, 15);
            this.ctrlRemote.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlRemote.Name = "ctrlRemote";
            this.ctrlRemote.Size = new System.Drawing.Size(85, 91);
            this.ctrlRemote.TabIndex = 3;
            // 
            // ctrlMdi
            // 
            this.ctrlMdi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlMdi.Location = new System.Drawing.Point(203, 15);
            this.ctrlMdi.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlMdi.Name = "ctrlMdi";
            this.ctrlMdi.Size = new System.Drawing.Size(85, 91);
            this.ctrlMdi.TabIndex = 2;
            // 
            // ctrlEdit
            // 
            this.ctrlEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlEdit.Location = new System.Drawing.Point(109, 15);
            this.ctrlEdit.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlEdit.Name = "ctrlEdit";
            this.ctrlEdit.Size = new System.Drawing.Size(85, 91);
            this.ctrlEdit.TabIndex = 1;
            // 
            // ctrlAuto
            // 
            this.ctrlAuto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlAuto.Location = new System.Drawing.Point(16, 15);
            this.ctrlAuto.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlAuto.Name = "ctrlAuto";
            this.ctrlAuto.Size = new System.Drawing.Size(85, 91);
            this.ctrlAuto.TabIndex = 0;
            // 
            // ctrlRecoaterRollerOn
            // 
            this.ctrlRecoaterRollerOn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlRecoaterRollerOn.Location = new System.Drawing.Point(605, 411);
            this.ctrlRecoaterRollerOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlRecoaterRollerOn.Name = "ctrlRecoaterRollerOn";
            this.ctrlRecoaterRollerOn.Size = new System.Drawing.Size(85, 91);
            this.ctrlRecoaterRollerOn.TabIndex = 30;
            // 
            // ctrlRecoaterRollerOff
            // 
            this.ctrlRecoaterRollerOff.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlRecoaterRollerOff.Location = new System.Drawing.Point(698, 411);
            this.ctrlRecoaterRollerOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlRecoaterRollerOff.Name = "ctrlRecoaterRollerOff";
            this.ctrlRecoaterRollerOff.Size = new System.Drawing.Size(85, 91);
            this.ctrlRecoaterRollerOff.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1191, 599);
            this.Controls.Add(this.ctrlRecoaterRollerOff);
            this.Controls.Add(this.ctrlRecoaterRollerOn);
            this.Controls.Add(this.ctrlPMCAXISON);
            this.Controls.Add(this.ctrlPathMinus);
            this.Controls.Add(this.ctrlPathPlus);
            this.Controls.Add(this.ctrlPSynch);
            this.Controls.Add(this.ctrlX1000);
            this.Controls.Add(this.ctrlX100);
            this.Controls.Add(this.ctrlX10);
            this.Controls.Add(this.ctrlX1);
            this.Controls.Add(this.ctrlRestart);
            this.Controls.Add(this.ctrlCycleStart);
            this.Controls.Add(this.ctrlCycleStop);
            this.Controls.Add(this.ctrlMinus);
            this.Controls.Add(this.ctrlPlus);
            this.Controls.Add(this.ctrlAxis8);
            this.Controls.Add(this.ctrlAxis7);
            this.Controls.Add(this.ctrlAxis6);
            this.Controls.Add(this.ctrlAxis5);
            this.Controls.Add(this.ctrlAxis4);
            this.Controls.Add(this.ctrlZ);
            this.Controls.Add(this.ctrlY);
            this.Controls.Add(this.ctrlX);
            this.Controls.Add(this.ctrlHandle);
            this.Controls.Add(this.ctrlInc);
            this.Controls.Add(this.ctrlJog);
            this.Controls.Add(this.ctrlRef);
            this.Controls.Add(this.ctrlRemote);
            this.Controls.Add(this.ctrlMdi);
            this.Controls.Add(this.ctrlEdit);
            this.Controls.Add(this.ctrlAuto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MDI Panel";
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorkerCommand;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUpdate;
        private UserCtrl.CtrlButtonLed ctrlAuto;
        private UserCtrl.CtrlButtonLed ctrlEdit;
        private UserCtrl.CtrlButtonLed ctrlMdi;
        private UserCtrl.CtrlButtonLed ctrlRemote;
        private UserCtrl.CtrlButtonLed ctrlRef;
        private UserCtrl.CtrlButtonLed ctrlJog;
        private UserCtrl.CtrlButtonLed ctrlInc;
        private UserCtrl.CtrlButtonLed ctrlHandle;
        private UserCtrl.CtrlButtonLed ctrlX;
        private UserCtrl.CtrlButtonLed ctrlY;
        private UserCtrl.CtrlButtonLed ctrlZ;
        private UserCtrl.CtrlButtonLed ctrlAxis4;
        private UserCtrl.CtrlButtonLed ctrlAxis5;
        private UserCtrl.CtrlButtonLed ctrlAxis6;
        private UserCtrl.CtrlButtonLed ctrlAxis7;
        private UserCtrl.CtrlButtonLed ctrlAxis8;
        private UserCtrl.CtrlButtonLed ctrlPlus;
        private UserCtrl.CtrlButtonLed ctrlMinus;
        private UserCtrl.CtrlButtonLed ctrlCycleStop;
        private UserCtrl.CtrlButtonLed ctrlCycleStart;
        private UserCtrl.CtrlButtonLed ctrlRestart;
        private UserCtrl.CtrlButtonLed ctrlX1;
        private UserCtrl.CtrlButtonLed ctrlX10;
        private UserCtrl.CtrlButtonLed ctrlX100;
        private UserCtrl.CtrlButtonLed ctrlX1000;
        private UserCtrl.CtrlButtonLed ctrlPSynch;
        private UserCtrl.CtrlButtonLed ctrlPathPlus;
        private UserCtrl.CtrlButtonLed ctrlPathMinus;
        private UserCtrl.CtrlButtonLed ctrlPMCAXISON;
        private UserCtrl.CtrlButtonLed ctrlRecoaterRollerOn;
        private UserCtrl.CtrlButtonLed ctrlRecoaterRollerOff;
    }
}

