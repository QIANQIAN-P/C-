namespace S7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiPanel1 = new Sunny.UI.UIPanel();
            s7Status = new Sunny.UI.UILight();
            uiTemputrue = new Sunny.UI.UIDigitalLabel();
            uiBattery1 = new Sunny.UI.UIBattery();
            uiTurnSwitch1 = new Sunny.UI.UITurnSwitch();
            s7Solt = new Sunny.UI.UIIntegerUpDown();
            s7Rack = new Sunny.UI.UIIntegerUpDown();
            s7Port = new Sunny.UI.UIIntegerUpDown();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            s7IP = new Sunny.UI.UIIPTextBox();
            uiPanel2 = new Sunny.UI.UIPanel();
            gridPlc = new Sunny.UI.UIDataGridView();
            uiPanel3 = new Sunny.UI.UIPanel();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPlc).BeginInit();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(s7Status);
            uiPanel1.Controls.Add(uiTemputrue);
            uiPanel1.Controls.Add(uiBattery1);
            uiPanel1.Controls.Add(uiTurnSwitch1);
            uiPanel1.Controls.Add(s7Solt);
            uiPanel1.Controls.Add(s7Rack);
            uiPanel1.Controls.Add(s7Port);
            uiPanel1.Controls.Add(uiLabel4);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(uiLabel3);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(s7IP);
            uiPanel1.Dock = DockStyle.Top;
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(0, 35);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(938, 128);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // s7Status
            // 
            s7Status.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            s7Status.Location = new Point(884, 5);
            s7Status.MinimumSize = new Size(1, 1);
            s7Status.Name = "s7Status";
            s7Status.Radius = 35;
            s7Status.Size = new Size(35, 35);
            s7Status.State = Sunny.UI.UILightState.Off;
            s7Status.TabIndex = 11;
            s7Status.Text = "uiLight1";
            // 
            // uiTemputrue
            // 
            uiTemputrue.BackColor = Color.Black;
            uiTemputrue.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTemputrue.ForeColor = Color.Lime;
            uiTemputrue.Location = new Point(800, 62);
            uiTemputrue.MinimumSize = new Size(1, 1);
            uiTemputrue.Name = "uiTemputrue";
            uiTemputrue.Size = new Size(119, 42);
            uiTemputrue.TabIndex = 10;
            uiTemputrue.Text = "uiDigitalLabel1";
            // 
            // uiBattery1
            // 
            uiBattery1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiBattery1.Location = new Point(816, 13);
            uiBattery1.MinimumSize = new Size(1, 1);
            uiBattery1.Name = "uiBattery1";
            uiBattery1.Size = new Size(48, 24);
            uiBattery1.TabIndex = 9;
            uiBattery1.Text = "uiBattery1";
            // 
            // uiTurnSwitch1
            // 
            uiTurnSwitch1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTurnSwitch1.Location = new Point(580, 5);
            uiTurnSwitch1.MinimumSize = new Size(1, 1);
            uiTurnSwitch1.Name = "uiTurnSwitch1";
            uiTurnSwitch1.Size = new Size(120, 120);
            uiTurnSwitch1.TabIndex = 8;
            uiTurnSwitch1.Text = "uiTurnSwitch1";
            uiTurnSwitch1.ValueChanged += uiTurnSwitch1_ValueChanged;
            // 
            // s7Solt
            // 
            s7Solt.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            s7Solt.Location = new Point(418, 80);
            s7Solt.Margin = new Padding(4, 5, 4, 5);
            s7Solt.MinimumSize = new Size(100, 0);
            s7Solt.Name = "s7Solt";
            s7Solt.ShowText = false;
            s7Solt.Size = new Size(146, 24);
            s7Solt.TabIndex = 6;
            s7Solt.Text = "uiIntegerUpDown2";
            s7Solt.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // s7Rack
            // 
            s7Rack.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            s7Rack.Location = new Point(418, 30);
            s7Rack.Margin = new Padding(4, 5, 4, 5);
            s7Rack.MinimumSize = new Size(100, 0);
            s7Rack.Name = "s7Rack";
            s7Rack.ShowText = false;
            s7Rack.Size = new Size(146, 24);
            s7Rack.TabIndex = 6;
            s7Rack.Text = "uiIntegerUpDown3";
            s7Rack.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // s7Port
            // 
            s7Port.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            s7Port.Location = new Point(133, 80);
            s7Port.Margin = new Padding(4, 5, 4, 5);
            s7Port.MinimumSize = new Size(100, 0);
            s7Port.Name = "s7Port";
            s7Port.ShowText = false;
            s7Port.Size = new Size(146, 24);
            s7Port.TabIndex = 5;
            s7Port.Text = null;
            s7Port.TextAlignment = ContentAlignment.MiddleCenter;
            s7Port.Value = 102;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(298, 80);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(113, 26);
            uiLabel4.TabIndex = 4;
            uiLabel4.Text = "西门子槽号";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(13, 80);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(100, 26);
            uiLabel2.TabIndex = 4;
            uiLabel2.Text = "西门子端口号";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(298, 30);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(113, 26);
            uiLabel3.TabIndex = 4;
            uiLabel3.Text = "西门子机架号";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(13, 28);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(110, 26);
            uiLabel1.TabIndex = 4;
            uiLabel1.Text = "西门子IP地址";
            // 
            // s7IP
            // 
            s7IP.FillColor2 = Color.FromArgb(235, 243, 255);
            s7IP.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            s7IP.Location = new Point(133, 28);
            s7IP.Margin = new Padding(4, 5, 4, 5);
            s7IP.MinimumSize = new Size(1, 1);
            s7IP.Name = "s7IP";
            s7IP.Padding = new Padding(1);
            s7IP.ShowText = false;
            s7IP.Size = new Size(146, 26);
            s7IP.TabIndex = 0;
            s7IP.Text = "127.0.0.1";
            s7IP.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(gridPlc);
            uiPanel2.Dock = DockStyle.Left;
            uiPanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel2.Location = new Point(0, 163);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(270, 392);
            uiPanel2.TabIndex = 1;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // gridPlc
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            gridPlc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridPlc.BackgroundColor = Color.White;
            gridPlc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridPlc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridPlc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridPlc.DefaultCellStyle = dataGridViewCellStyle3;
            gridPlc.Dock = DockStyle.Fill;
            gridPlc.EnableHeadersVisualStyles = false;
            gridPlc.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            gridPlc.GridColor = Color.FromArgb(80, 160, 255);
            gridPlc.Location = new Point(0, 0);
            gridPlc.Name = "gridPlc";
            gridPlc.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridPlc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            gridPlc.RowsDefaultCellStyle = dataGridViewCellStyle5;
            gridPlc.SelectedIndex = -1;
            gridPlc.Size = new Size(270, 392);
            gridPlc.StripeOddColor = Color.FromArgb(235, 243, 255);
            gridPlc.TabIndex = 0;
            // 
            // uiPanel3
            // 
            uiPanel3.Dock = DockStyle.Fill;
            uiPanel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel3.Location = new Point(270, 163);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Size = new Size(668, 392);
            uiPanel3.TabIndex = 1;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(938, 555);
            Controls.Add(uiPanel3);
            Controls.Add(uiPanel2);
            Controls.Add(uiPanel1);
            Name = "Form1";
            Text = "Form1";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            uiPanel1.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPlc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIIPTextBox s7IP;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIIntegerUpDown s7Port;
        private Sunny.UI.UITurnSwitch uiTurnSwitch1;
        private Sunny.UI.UIIntegerUpDown s7Solt;
        private Sunny.UI.UIIntegerUpDown s7Rack;
        private Sunny.UI.UIDigitalLabel uiTemputrue;
        private Sunny.UI.UIBattery uiBattery1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIDataGridView gridPlc;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UILight s7Status;
    }
}
