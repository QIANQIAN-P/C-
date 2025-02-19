namespace SerialPortPro
{
    partial class 串口通信助手
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
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.groupControlReceive = new DevExpress.XtraEditors.GroupControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.checkEditRecAuto = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditRecFile = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditRecLog = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditRecHex = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditRecAscii = new DevExpress.XtraEditors.CheckEdit();
            this.groupControlSend = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEditSendCycle = new DevExpress.XtraEditors.TextEdit();
            this.checkEditSendCycle = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditSendRandom = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditSendAscii = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditSendHex = new DevExpress.XtraEditors.CheckEdit();
            this.groupControlPort = new DevExpress.XtraEditors.GroupControl();
            this.btnOpen = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEditStopBit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditDataBit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditParity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditBaund = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditPort = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.memoEditlog = new DevExpress.XtraEditors.MemoEdit();
            this.groupControlInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.memoEditSendLog = new DevExpress.XtraEditors.MemoEdit();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlReceive)).BeginInit();
            this.groupControlReceive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRecAuto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRecFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRecLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRecHex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRecAscii.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSend)).BeginInit();
            this.groupControlSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSendCycle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSendCycle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSendRandom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSendAscii.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSendHex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPort)).BeginInit();
            this.groupControlPort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditStopBit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDataBit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditParity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBaund.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditlog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).BeginInit();
            this.groupControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditSendLog.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl6);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(233, 661);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.groupControlReceive);
            this.panelControl6.Controls.Add(this.groupControlSend);
            this.panelControl6.Controls.Add(this.groupControlPort);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl6.Location = new System.Drawing.Point(2, 2);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(229, 657);
            this.panelControl6.TabIndex = 2;
            // 
            // groupControlReceive
            // 
            this.groupControlReceive.Controls.Add(this.btnClear);
            this.groupControlReceive.Controls.Add(this.checkEditRecAuto);
            this.groupControlReceive.Controls.Add(this.checkEditRecFile);
            this.groupControlReceive.Controls.Add(this.checkEditRecLog);
            this.groupControlReceive.Controls.Add(this.checkEditRecHex);
            this.groupControlReceive.Controls.Add(this.checkEditRecAscii);
            this.groupControlReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlReceive.Location = new System.Drawing.Point(2, 249);
            this.groupControlReceive.Name = "groupControlReceive";
            this.groupControlReceive.Size = new System.Drawing.Size(225, 237);
            this.groupControlReceive.TabIndex = 2;
            this.groupControlReceive.Text = "接收设置";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(17, 186);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(187, 35);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清除接收";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // checkEditRecAuto
            // 
            this.checkEditRecAuto.Location = new System.Drawing.Point(17, 145);
            this.checkEditRecAuto.Name = "checkEditRecAuto";
            this.checkEditRecAuto.Properties.Caption = "自动滚屏";
            this.checkEditRecAuto.Size = new System.Drawing.Size(143, 19);
            this.checkEditRecAuto.TabIndex = 1;
            // 
            // checkEditRecFile
            // 
            this.checkEditRecFile.Location = new System.Drawing.Point(17, 112);
            this.checkEditRecFile.Name = "checkEditRecFile";
            this.checkEditRecFile.Properties.Caption = "接收保存到文件";
            this.checkEditRecFile.Size = new System.Drawing.Size(143, 19);
            this.checkEditRecFile.TabIndex = 1;
            this.checkEditRecFile.CheckedChanged += new System.EventHandler(this.checkEditRecFile_CheckedChanged);
            // 
            // checkEditRecLog
            // 
            this.checkEditRecLog.Location = new System.Drawing.Point(17, 79);
            this.checkEditRecLog.Name = "checkEditRecLog";
            this.checkEditRecLog.Properties.Caption = "按日志模式显示";
            this.checkEditRecLog.Size = new System.Drawing.Size(143, 19);
            this.checkEditRecLog.TabIndex = 1;
            this.checkEditRecLog.CheckedChanged += new System.EventHandler(this.checkEditRecLog_CheckedChanged);
            // 
            // checkEditRecHex
            // 
            this.checkEditRecHex.Location = new System.Drawing.Point(129, 39);
            this.checkEditRecHex.Name = "checkEditRecHex";
            this.checkEditRecHex.Properties.Caption = "HEX";
            this.checkEditRecHex.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.checkEditRecHex.Properties.RadioGroupIndex = 1;
            this.checkEditRecHex.Size = new System.Drawing.Size(75, 19);
            this.checkEditRecHex.TabIndex = 0;
            this.checkEditRecHex.TabStop = false;
            // 
            // checkEditRecAscii
            // 
            this.checkEditRecAscii.Location = new System.Drawing.Point(16, 39);
            this.checkEditRecAscii.Name = "checkEditRecAscii";
            this.checkEditRecAscii.Properties.Caption = "ASCII";
            this.checkEditRecAscii.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.checkEditRecAscii.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.checkEditRecAscii.Properties.RadioGroupIndex = 1;
            this.checkEditRecAscii.Size = new System.Drawing.Size(75, 19);
            this.checkEditRecAscii.TabIndex = 0;
            this.checkEditRecAscii.TabStop = false;
            // 
            // groupControlSend
            // 
            this.groupControlSend.Controls.Add(this.labelControl6);
            this.groupControlSend.Controls.Add(this.textEditSendCycle);
            this.groupControlSend.Controls.Add(this.checkEditSendCycle);
            this.groupControlSend.Controls.Add(this.checkEditSendRandom);
            this.groupControlSend.Controls.Add(this.checkEditSendAscii);
            this.groupControlSend.Controls.Add(this.checkEditSendHex);
            this.groupControlSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlSend.Location = new System.Drawing.Point(2, 486);
            this.groupControlSend.Name = "groupControlSend";
            this.groupControlSend.Size = new System.Drawing.Size(225, 169);
            this.groupControlSend.TabIndex = 1;
            this.groupControlSend.Text = "发送设置";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(158, 125);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(15, 14);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "ms";
            // 
            // textEditSendCycle
            // 
            this.textEditSendCycle.EditValue = "1000";
            this.textEditSendCycle.Location = new System.Drawing.Point(88, 122);
            this.textEditSendCycle.Name = "textEditSendCycle";
            this.textEditSendCycle.Properties.Appearance.Options.UseTextOptions = true;
            this.textEditSendCycle.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEditSendCycle.Properties.BeepOnError = true;
            this.textEditSendCycle.Size = new System.Drawing.Size(63, 20);
            this.textEditSendCycle.TabIndex = 2;
            // 
            // checkEditSendCycle
            // 
            this.checkEditSendCycle.Location = new System.Drawing.Point(20, 122);
            this.checkEditSendCycle.Name = "checkEditSendCycle";
            this.checkEditSendCycle.Properties.Caption = "循环周期";
            this.checkEditSendCycle.Size = new System.Drawing.Size(71, 19);
            this.checkEditSendCycle.TabIndex = 1;
            // 
            // checkEditSendRandom
            // 
            this.checkEditSendRandom.Location = new System.Drawing.Point(20, 85);
            this.checkEditSendRandom.Name = "checkEditSendRandom";
            this.checkEditSendRandom.Properties.Caption = "生成随机数";
            this.checkEditSendRandom.Size = new System.Drawing.Size(102, 19);
            this.checkEditSendRandom.TabIndex = 1;
            // 
            // checkEditSendAscii
            // 
            this.checkEditSendAscii.Location = new System.Drawing.Point(17, 41);
            this.checkEditSendAscii.Name = "checkEditSendAscii";
            this.checkEditSendAscii.Properties.Caption = "ASCII";
            this.checkEditSendAscii.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.checkEditSendAscii.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.checkEditSendAscii.Properties.RadioGroupIndex = 1;
            this.checkEditSendAscii.Size = new System.Drawing.Size(75, 19);
            this.checkEditSendAscii.TabIndex = 0;
            this.checkEditSendAscii.TabStop = false;
            // 
            // checkEditSendHex
            // 
            this.checkEditSendHex.Location = new System.Drawing.Point(129, 41);
            this.checkEditSendHex.Name = "checkEditSendHex";
            this.checkEditSendHex.Properties.Caption = "HEX";
            this.checkEditSendHex.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.checkEditSendHex.Properties.RadioGroupIndex = 1;
            this.checkEditSendHex.Size = new System.Drawing.Size(75, 19);
            this.checkEditSendHex.TabIndex = 0;
            this.checkEditSendHex.TabStop = false;
            // 
            // groupControlPort
            // 
            this.groupControlPort.Controls.Add(this.btnOpen);
            this.groupControlPort.Controls.Add(this.comboBoxEditStopBit);
            this.groupControlPort.Controls.Add(this.comboBoxEditDataBit);
            this.groupControlPort.Controls.Add(this.comboBoxEditParity);
            this.groupControlPort.Controls.Add(this.comboBoxEditBaund);
            this.groupControlPort.Controls.Add(this.comboBoxEditPort);
            this.groupControlPort.Controls.Add(this.labelControl5);
            this.groupControlPort.Controls.Add(this.labelControl4);
            this.groupControlPort.Controls.Add(this.labelControl3);
            this.groupControlPort.Controls.Add(this.labelControl2);
            this.groupControlPort.Controls.Add(this.labelControl1);
            this.groupControlPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlPort.Location = new System.Drawing.Point(2, 2);
            this.groupControlPort.Name = "groupControlPort";
            this.groupControlPort.Size = new System.Drawing.Size(225, 247);
            this.groupControlPort.TabIndex = 0;
            this.groupControlPort.Text = "串口设置";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(17, 203);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(188, 35);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "打开";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // comboBoxEditStopBit
            // 
            this.comboBoxEditStopBit.Location = new System.Drawing.Point(104, 172);
            this.comboBoxEditStopBit.Name = "comboBoxEditStopBit";
            this.comboBoxEditStopBit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditStopBit.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditStopBit.TabIndex = 1;
            // 
            // comboBoxEditDataBit
            // 
            this.comboBoxEditDataBit.Location = new System.Drawing.Point(104, 136);
            this.comboBoxEditDataBit.Name = "comboBoxEditDataBit";
            this.comboBoxEditDataBit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditDataBit.Properties.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxEditDataBit.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditDataBit.TabIndex = 1;
            // 
            // comboBoxEditParity
            // 
            this.comboBoxEditParity.Location = new System.Drawing.Point(104, 102);
            this.comboBoxEditParity.Name = "comboBoxEditParity";
            this.comboBoxEditParity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditParity.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditParity.TabIndex = 1;
            // 
            // comboBoxEditBaund
            // 
            this.comboBoxEditBaund.Location = new System.Drawing.Point(104, 68);
            this.comboBoxEditBaund.Name = "comboBoxEditBaund";
            this.comboBoxEditBaund.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditBaund.Properties.Items.AddRange(new object[] {
            "1382400",
            "921600",
            "460800",
            "256000",
            "230400",
            "128000",
            "115200",
            "76800",
            "57600",
            "43000",
            "38400",
            "19200",
            "14400",
            "9600",
            "4800",
            "1200"});
            this.comboBoxEditBaund.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditBaund.TabIndex = 1;
            // 
            // comboBoxEditPort
            // 
            this.comboBoxEditPort.Location = new System.Drawing.Point(104, 34);
            this.comboBoxEditPort.Name = "comboBoxEditPort";
            this.comboBoxEditPort.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditPort.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditPort.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 175);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "停止位";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 139);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "数据位";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 105);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "校验位";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "波特率";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "串口号";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl);
            this.panelControl2.Controls.Add(this.groupControlInfo);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(233, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(846, 661);
            this.panelControl2.TabIndex = 1;
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.memoEditlog);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.Location = new System.Drawing.Point(2, 2);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(842, 504);
            this.groupControl.TabIndex = 3;
            this.groupControl.Text = "数据日志";
            // 
            // memoEditLog
            // 
            this.memoEditlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEditlog.Location = new System.Drawing.Point(2, 22);
            this.memoEditlog.Name = "memoEditLog";
            this.memoEditlog.Size = new System.Drawing.Size(838, 480);
            this.memoEditlog.TabIndex = 2;
            // 
            // groupControlInfo
            // 
            this.groupControlInfo.Controls.Add(this.btnSend);
            this.groupControlInfo.Controls.Add(this.memoEditSendLog);
            this.groupControlInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlInfo.Location = new System.Drawing.Point(2, 506);
            this.groupControlInfo.Name = "groupControlInfo";
            this.groupControlInfo.ShowCaption = false;
            this.groupControlInfo.Size = new System.Drawing.Size(842, 153);
            this.groupControlInfo.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Location = new System.Drawing.Point(686, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(154, 149);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "发送";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // memoEditSendLog
            // 
            this.memoEditSendLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.memoEditSendLog.Location = new System.Drawing.Point(2, 2);
            this.memoEditSendLog.Name = "memoEditSendLog";
            this.memoEditSendLog.Size = new System.Drawing.Size(684, 149);
            this.memoEditSendLog.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // 串口通信助手
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 661);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.SkinName = "Office 2007 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "串口通信助手";
            this.Text = "串口通信助手";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlReceive)).EndInit();
            this.groupControlReceive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRecAuto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRecFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRecLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRecHex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRecAscii.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSend)).EndInit();
            this.groupControlSend.ResumeLayout(false);
            this.groupControlSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSendCycle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSendCycle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSendRandom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSendAscii.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSendHex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPort)).EndInit();
            this.groupControlPort.ResumeLayout(false);
            this.groupControlPort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditStopBit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDataBit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditParity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBaund.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditlog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).EndInit();
            this.groupControlInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditSendLog.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.GroupControl groupControlReceive;
        private DevExpress.XtraEditors.GroupControl groupControlSend;
        private DevExpress.XtraEditors.GroupControl groupControlPort;
        private DevExpress.XtraEditors.MemoEdit memoEditlog;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.GroupControl groupControlInfo;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.MemoEdit memoEditSendLog;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditPort;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditStopBit;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditDataBit;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditParity;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditBaund;
        private DevExpress.XtraEditors.SimpleButton btnOpen;
        private DevExpress.XtraEditors.CheckEdit checkEditRecHex;
        private DevExpress.XtraEditors.CheckEdit checkEditRecAscii;
        private DevExpress.XtraEditors.CheckEdit checkEditRecAuto;
        private DevExpress.XtraEditors.CheckEdit checkEditRecFile;
        private DevExpress.XtraEditors.CheckEdit checkEditRecLog;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.CheckEdit checkEditSendAscii;
        private DevExpress.XtraEditors.CheckEdit checkEditSendHex;
        private DevExpress.XtraEditors.CheckEdit checkEditSendCycle;
        private DevExpress.XtraEditors.CheckEdit checkEditSendRandom;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEditSendCycle;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

