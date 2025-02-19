using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication1.UserControl
{
    public partial class MultiThreadRefrashUc : DevExpress.XtraEditors.XtraUserControl
    {
       private  Thread randomThread;
        private bool _start;
        public Action<string> TranformTextAction;//实现主次界面数据同步-数据回调
        public MultiThreadRefrashUc()
        {
            InitializeComponent();
                 
        }

        public void ClickUpByRandom()
        {
            //状态切换
            _start = !_start ;
            if (_start)
            {
                //线程开始，刷新UI
                GenerateRandomByThread();
                GenerateRandomByTask();

            }
            //else
            //{
            //    //线程终止
            //    randomThread.Abort();//Abort用法
            //}
        }

        private void GenerateRandomByThread()
        {

            randomThread = new Thread(start: () =>//randomThread局部变量改全局变量
                                                  //var randomThread = new Thread(start: () =>   委托事件，lambda表达式
            {
                while (_start)
                {
                    var randomNumber = new Random().Next(1, 100).ToString();//取随机数

                    UpdateUi(() =>
                    {
                        textEditThread.Text = randomNumber;//为什么用驼峰法
                    });

                    Thread.Sleep(300);//睡眠300ms
                }
            }

            );
            randomThread.Start();//这句没加，start就只启动一次
        }

        //private void GenerateRandomByTask()
        //{
        //    Task.Run ( () =>  //看不懂,看异步教程
        //    {
        //        while (_start)
        //        {
        //            var randomNumber = new Random().Next(1, 100).ToString();
        //            textEditTask.Text = randomNumber;

        //            Thread.Sleep(300);
        //        }
        //    }

        //    );
        //}

        private void GenerateRandomByTask()
        {

            Task.Run(async () =>
            {
                while (_start)
                {
                    var randomNumber = new Random().Next(1, 100).ToString();
                    UpdateUi(() =>
                    {
                        textEditTask.Text = randomNumber;
                        TranformTextAction?.Invoke(textEditTask.Text);//值不为空就回调/传

                    });
                    await Task.Delay(300);
                }
                
            });

        }

        private void UpdateUi(Action action)//这整行代码不理解,委托
        {
            if (this.IsHandleCreated ) 
            { 
            this .Invoke(action);
            }
        }

    }
}
