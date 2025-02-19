using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication1.Models;

namespace DXApplication1.UserControl
{
    public partial class PageLogUc : DevExpress.XtraEditors.XtraUserControl
    {
        //
        private int _pageSize=20, _page=1,_totalPage=1;

        private bool _isChangeByUser=true;

        private long _totalRecord=999;

        private BindingList<LogModel> _records;

        public PageLogUc()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            dtStart.DateTime = DateTime.Now.AddDays(-1);
            dtEnd.DateTimeOffset = DateTime.Now;
            barStaticItemStatus.Caption = "数据加载中...";
            var records = FindRecords();
            _totalRecord = records.Count;//xx.Count 必须要建立list<t>格式的方法
            _records = new BindingList<LogModel>(records);
            SetPage(1, _totalRecord);//初始化页面,注意_totalRecord和_totalPage不一样
            BindDataSource();
            barStaticItemStatus.Caption = "数据加载成功...";
        }
        //挑选需要的数据加载到控件中
        private void BindDataSource()
        {
            gridControlLog.DataSource = _records.Skip(_pageSize*(_page-1)).Take(_pageSize).ToList();    
        }
        //定义翻页按钮的使用条件
        private void SetPage(int page,long total)
        {
            _totalPage = (int)Math.Ceiling((double)total/_pageSize);//计算总页数
            if (_totalPage <= 1)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
                txtPage.Enabled = false;

            }
            else if (page == 1)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
                txtPage.Enabled = true;

            }
            else if (page == _totalPage)
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
                txtPage.Enabled = true;
            }
            else 
            {
                btnFirst.Enabled = true;        
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
                txtPage.Enabled = true;
            }
            _page = page;
            _isChangeByUser = false;
            txtPage.EditValue = page;
            _isChangeByUser = true;
            if (total == 0)
            {
                lblSummary.Caption = "没有记录";
            }
            else 
            {
                lblSummary.Caption = $"共{_totalPage}页，第{(_pageSize)*(page-1)+1}到{(page==_totalPage?total:_pageSize*page)}条，共{total}条";
            }
        }

        private void btnFirst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetPage(1,_totalRecord);
            BindDataSource();
        }

        private void btnPrevious_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetPage(_page-1, _totalRecord);
            BindDataSource();
        }
           

        private void btnNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetPage(_page+1, _totalRecord);
            BindDataSource();
        }

        private void btnLast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetPage(_totalPage, _totalRecord);
            BindDataSource();
        }
                       
        private void txtPage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!_isChangeByUser)
            {
                return;
            }
            if (txtPage.EditValue.ToString() == "")
            {
                SetPage(1, _totalRecord);
                return;
            }
            int page = Convert.ToInt32(txtPage.EditValue);
            if (page < 1)
            {
                SetPage(1, _totalRecord);
            }
            else if (page > _totalPage)
            {
                SetPage(_totalPage, _totalRecord);
            }
            else
            {
                SetPage(page, _totalRecord);
            }
        }
        //从数据库查询数据
        private async void btnFind_Click(object sender, EventArgs e)
        {
            await Task.Delay(1000); 
            //
            var records=FindRecords().Where(x=>x.OperationTime>=dtStart.DateTime&&x.OperationTime<=dtEnd.DateTimeOffset).ToList();
            _totalRecord = records.Count();
            _records = new BindingList<LogModel> (records);
            SetPage(1,_totalRecord);//一样的问题，选择的参数不对
            BindDataSource();
        }
        //重置时间
        private void btnReset_Click(object sender, EventArgs e)
        {
            dtStart.DateTime = DateTime.Now.AddDays(-1);
            dtEnd.DateTimeOffset = DateTime.Now;
        }

        private void PageLogUc_Load(object sender, EventArgs e)
        {
            // 开启双缓冲，减少闪烁
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }
        //生成随机的用户数据
        private List<LogModel> FindRecords()
        {
            var logModels = new List<LogModel>();
            Random random = new Random();
            DateTime now =DateTime.Now;
            for (int i = 0; i < 2000; i++)
            {
                TimeSpan randomTimeSpan = new TimeSpan(0,random.Next( 7 * 24 * 60), 0);
                //random.Next( 7 * 24 * 60)和7 * 24 * 60可不一样
                DateTime randomTime = now - randomTimeSpan;
                logModels.Add(new LogModel()
                {
                    Id = i,UserName="Admin",Operation=$"登录{i}",
                    OperationTime=randomTime,IpAddress="127.0.0.1"
                });
            }

            return logModels;
            
        }
    }
}
