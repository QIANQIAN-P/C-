using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication1.UserControl;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private PageLogUc pageLogUc;

        public Form1()
        {
            InitializeComponent();
            InitEvents();
        }
        //数据回调
        //-----------------------------------------------------------------------------
        private void InitEvents()
        {
            multiThreadRefrashUc1.TranformTextAction += TransformTextActionHandler;
        }

        private void TransformTextActionHandler(string inputRandom)
        {
            labelControl1.Text=inputRandom;
        }
        //-----------------------------------------------------------------------------

        private void multiThreadRefrashUc1_Load(object sender, EventArgs e)
        {

        }
        //查询日志
        private void btnlog_Click(object sender, EventArgs e)
        {

            if (pageLogUc == null)
            {
                pageLogUc = new PageLogUc();
            }
            pageLogUc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(pageLogUc);
        }

       
    }
}
