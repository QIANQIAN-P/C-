namespace DXApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnlog = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControlMain = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.multiThreadRefrashUc1 = new DXApplication1.UserControl.MultiThreadRefrashUc();
            this.panelContainer = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnlog);
            this.panelControl3.Controls.Add(this.simpleButton3);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1030, 78);
            this.panelControl3.TabIndex = 0;
            // 
            // btnlog
            // 
            this.btnlog.AutoSize = true;
            this.btnlog.AutoWidthInLayoutControl = true;
            this.btnlog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlog.ImageOptions.Image")));
            this.btnlog.Location = new System.Drawing.Point(175, 22);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(92, 38);
            this.btnlog.TabIndex = 0;
            this.btnlog.Text = "分页日志";
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.AutoSize = true;
            this.simpleButton3.AutoWidthInLayoutControl = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(40, 22);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(104, 38);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "多线程刷新";
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.panelContainer);
            this.panelControlMain.Controls.Add(this.panelControl5);
            this.panelControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlMain.Location = new System.Drawing.Point(0, 78);
            this.panelControlMain.Name = "panelControlMain";
            this.panelControlMain.Size = new System.Drawing.Size(1030, 515);
            this.panelControlMain.TabIndex = 1;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.labelControl1);
            this.panelControl5.Controls.Add(this.multiThreadRefrashUc1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl5.Location = new System.Drawing.Point(2, 2);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(349, 511);
            this.panelControl5.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(38, 147);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "无数据同步";
            // 
            // multiThreadRefrashUc1
            // 
            this.multiThreadRefrashUc1.Dock = System.Windows.Forms.DockStyle.Top;
            this.multiThreadRefrashUc1.Location = new System.Drawing.Point(2, 2);
            this.multiThreadRefrashUc1.Name = "multiThreadRefrashUc1";
            this.multiThreadRefrashUc1.Size = new System.Drawing.Size(345, 197);
            this.multiThreadRefrashUc1.TabIndex = 0;
            this.multiThreadRefrashUc1.Load += new System.EventHandler(this.multiThreadRefrashUc1_Load);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(351, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(677, 511);
            this.panelContainer.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1030, 593);
            this.Controls.Add(this.panelControlMain);
            this.Controls.Add(this.panelControl3);
            this.LookAndFeel.SkinName = "DevExpress Style";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnlog;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.PanelControl panelControlMain;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private UserControl.MultiThreadRefrashUc multiThreadRefrashUc1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelContainer;
    }
}

