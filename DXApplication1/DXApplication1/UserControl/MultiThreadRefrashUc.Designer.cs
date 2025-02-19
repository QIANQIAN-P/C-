namespace DXApplication1.UserControl
{
    partial class MultiThreadRefrashUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditThread = new DevExpress.XtraEditors.TextEdit();
            this.textEditTask = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditThread.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTask.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(34, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thread方式刷新";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(34, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Task方式刷新";
            // 
            // textEditThread
            // 
            this.textEditThread.Location = new System.Drawing.Point(168, 34);
            this.textEditThread.Name = "textEditThread";
            this.textEditThread.Size = new System.Drawing.Size(100, 20);
            this.textEditThread.TabIndex = 2;
            // 
            // textEditTask
            // 
            this.textEditTask.Location = new System.Drawing.Point(168, 93);
            this.textEditTask.Name = "textEditTask";
            this.textEditTask.Size = new System.Drawing.Size(100, 20);
            this.textEditTask.TabIndex = 2;
            // 
            // MultiThreadRefrashUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEditTask);
            this.Controls.Add(this.textEditThread);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "MultiThreadRefrashUc";
            this.Size = new System.Drawing.Size(329, 174);
            ((System.ComponentModel.ISupportInitialize)(this.textEditThread.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTask.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditThread;
        private DevExpress.XtraEditors.TextEdit textEditTask;
    }
}
