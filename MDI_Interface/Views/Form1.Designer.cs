
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
            this.ctrlAuto = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlEdit = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlMdi = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlRemote = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlRef = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlJog = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlInc = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlHandle = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlX = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlY = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlZ = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlAxis4 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlAxis5 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlAxis6 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlAxis7 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlAxis8 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlPlus = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlMinus = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlCycleStop = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlCycleStart = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlRestart = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlX1 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlX10 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlX100 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlX1000 = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlPSynch = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlPathPlus = new MDI_Interface.UserCtrl.CtrlButtonLed();
            this.ctrlPathMinus = new MDI_Interface.UserCtrl.CtrlButtonLed();
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
            // ctrlAuto
            // 
            this.ctrlAuto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlAuto.Location = new System.Drawing.Point(12, 12);
            this.ctrlAuto.Name = "ctrlAuto";
            this.ctrlAuto.Size = new System.Drawing.Size(64, 74);
            this.ctrlAuto.TabIndex = 0;
            // 
            // ctrlEdit
            // 
            this.ctrlEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlEdit.Location = new System.Drawing.Point(82, 12);
            this.ctrlEdit.Name = "ctrlEdit";
            this.ctrlEdit.Size = new System.Drawing.Size(64, 74);
            this.ctrlEdit.TabIndex = 1;
            // 
            // ctrlMdi
            // 
            this.ctrlMdi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlMdi.Location = new System.Drawing.Point(152, 12);
            this.ctrlMdi.Name = "ctrlMdi";
            this.ctrlMdi.Size = new System.Drawing.Size(64, 74);
            this.ctrlMdi.TabIndex = 2;
            // 
            // ctrlRemote
            // 
            this.ctrlRemote.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlRemote.Location = new System.Drawing.Point(222, 12);
            this.ctrlRemote.Name = "ctrlRemote";
            this.ctrlRemote.Size = new System.Drawing.Size(64, 74);
            this.ctrlRemote.TabIndex = 3;
            // 
            // ctrlRef
            // 
            this.ctrlRef.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlRef.Location = new System.Drawing.Point(12, 92);
            this.ctrlRef.Name = "ctrlRef";
            this.ctrlRef.Size = new System.Drawing.Size(64, 74);
            this.ctrlRef.TabIndex = 4;
            // 
            // ctrlJog
            // 
            this.ctrlJog.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlJog.Location = new System.Drawing.Point(82, 92);
            this.ctrlJog.Name = "ctrlJog";
            this.ctrlJog.Size = new System.Drawing.Size(64, 74);
            this.ctrlJog.TabIndex = 5;
            // 
            // ctrlInc
            // 
            this.ctrlInc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlInc.Location = new System.Drawing.Point(152, 92);
            this.ctrlInc.Name = "ctrlInc";
            this.ctrlInc.Size = new System.Drawing.Size(64, 74);
            this.ctrlInc.TabIndex = 6;
            // 
            // ctrlHandle
            // 
            this.ctrlHandle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlHandle.Location = new System.Drawing.Point(222, 92);
            this.ctrlHandle.Name = "ctrlHandle";
            this.ctrlHandle.Size = new System.Drawing.Size(64, 74);
            this.ctrlHandle.TabIndex = 7;
            // 
            // ctrlX
            // 
            this.ctrlX.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlX.Location = new System.Drawing.Point(383, 12);
            this.ctrlX.Name = "ctrlX";
            this.ctrlX.Size = new System.Drawing.Size(64, 74);
            this.ctrlX.TabIndex = 8;
            // 
            // ctrlY
            // 
            this.ctrlY.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlY.Location = new System.Drawing.Point(453, 12);
            this.ctrlY.Name = "ctrlY";
            this.ctrlY.Size = new System.Drawing.Size(64, 74);
            this.ctrlY.TabIndex = 9;
            // 
            // ctrlZ
            // 
            this.ctrlZ.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlZ.Location = new System.Drawing.Point(523, 12);
            this.ctrlZ.Name = "ctrlZ";
            this.ctrlZ.Size = new System.Drawing.Size(64, 74);
            this.ctrlZ.TabIndex = 10;
            // 
            // ctrlAxis4
            // 
            this.ctrlAxis4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlAxis4.Location = new System.Drawing.Point(383, 92);
            this.ctrlAxis4.Name = "ctrlAxis4";
            this.ctrlAxis4.Size = new System.Drawing.Size(64, 74);
            this.ctrlAxis4.TabIndex = 11;
            // 
            // ctrlAxis5
            // 
            this.ctrlAxis5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlAxis5.Location = new System.Drawing.Point(453, 92);
            this.ctrlAxis5.Name = "ctrlAxis5";
            this.ctrlAxis5.Size = new System.Drawing.Size(64, 74);
            this.ctrlAxis5.TabIndex = 12;
            // 
            // ctrlAxis6
            // 
            this.ctrlAxis6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlAxis6.Location = new System.Drawing.Point(523, 92);
            this.ctrlAxis6.Name = "ctrlAxis6";
            this.ctrlAxis6.Size = new System.Drawing.Size(64, 74);
            this.ctrlAxis6.TabIndex = 13;
            // 
            // ctrlAxis7
            // 
            this.ctrlAxis7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlAxis7.Location = new System.Drawing.Point(383, 172);
            this.ctrlAxis7.Name = "ctrlAxis7";
            this.ctrlAxis7.Size = new System.Drawing.Size(64, 74);
            this.ctrlAxis7.TabIndex = 14;
            // 
            // ctrlAxis8
            // 
            this.ctrlAxis8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlAxis8.Location = new System.Drawing.Point(453, 172);
            this.ctrlAxis8.Name = "ctrlAxis8";
            this.ctrlAxis8.Size = new System.Drawing.Size(64, 74);
            this.ctrlAxis8.TabIndex = 15;
            // 
            // ctrlPlus
            // 
            this.ctrlPlus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlPlus.Location = new System.Drawing.Point(383, 252);
            this.ctrlPlus.Name = "ctrlPlus";
            this.ctrlPlus.Size = new System.Drawing.Size(64, 74);
            this.ctrlPlus.TabIndex = 17;
            // 
            // ctrlMinus
            // 
            this.ctrlMinus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlMinus.Location = new System.Drawing.Point(523, 252);
            this.ctrlMinus.Name = "ctrlMinus";
            this.ctrlMinus.Size = new System.Drawing.Size(64, 74);
            this.ctrlMinus.TabIndex = 18;
            // 
            // ctrlCycleStop
            // 
            this.ctrlCycleStop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlCycleStop.Location = new System.Drawing.Point(12, 332);
            this.ctrlCycleStop.Name = "ctrlCycleStop";
            this.ctrlCycleStop.Size = new System.Drawing.Size(64, 74);
            this.ctrlCycleStop.TabIndex = 19;
            // 
            // ctrlCycleStart
            // 
            this.ctrlCycleStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlCycleStart.Location = new System.Drawing.Point(82, 332);
            this.ctrlCycleStart.Name = "ctrlCycleStart";
            this.ctrlCycleStart.Size = new System.Drawing.Size(64, 74);
            this.ctrlCycleStart.TabIndex = 20;
            // 
            // ctrlRestart
            // 
            this.ctrlRestart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlRestart.Location = new System.Drawing.Point(152, 332);
            this.ctrlRestart.Name = "ctrlRestart";
            this.ctrlRestart.Size = new System.Drawing.Size(64, 74);
            this.ctrlRestart.TabIndex = 21;
            // 
            // ctrlX1
            // 
            this.ctrlX1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlX1.Location = new System.Drawing.Point(12, 252);
            this.ctrlX1.Name = "ctrlX1";
            this.ctrlX1.Size = new System.Drawing.Size(64, 74);
            this.ctrlX1.TabIndex = 22;
            // 
            // ctrlX10
            // 
            this.ctrlX10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlX10.Location = new System.Drawing.Point(82, 252);
            this.ctrlX10.Name = "ctrlX10";
            this.ctrlX10.Size = new System.Drawing.Size(64, 74);
            this.ctrlX10.TabIndex = 23;
            // 
            // ctrlX100
            // 
            this.ctrlX100.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlX100.Location = new System.Drawing.Point(152, 252);
            this.ctrlX100.Name = "ctrlX100";
            this.ctrlX100.Size = new System.Drawing.Size(64, 74);
            this.ctrlX100.TabIndex = 24;
            // 
            // ctrlX1000
            // 
            this.ctrlX1000.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlX1000.Location = new System.Drawing.Point(222, 252);
            this.ctrlX1000.Name = "ctrlX1000";
            this.ctrlX1000.Size = new System.Drawing.Size(64, 74);
            this.ctrlX1000.TabIndex = 25;
            // 
            // ctrlPSynch
            // 
            this.ctrlPSynch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlPSynch.Location = new System.Drawing.Point(683, 12);
            this.ctrlPSynch.Name = "ctrlPSynch";
            this.ctrlPSynch.Size = new System.Drawing.Size(64, 74);
            this.ctrlPSynch.TabIndex = 26;
            // 
            // ctrlPathPlus
            // 
            this.ctrlPathPlus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlPathPlus.Location = new System.Drawing.Point(683, 92);
            this.ctrlPathPlus.Name = "ctrlPathPlus";
            this.ctrlPathPlus.Size = new System.Drawing.Size(64, 74);
            this.ctrlPathPlus.TabIndex = 27;
            // 
            // ctrlPathMinus
            // 
            this.ctrlPathMinus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlPathMinus.Location = new System.Drawing.Point(683, 172);
            this.ctrlPathMinus.Name = "ctrlPathMinus";
            this.ctrlPathMinus.Size = new System.Drawing.Size(64, 74);
            this.ctrlPathMinus.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 487);
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
    }
}

