using MiniExcelLibs;
using System.IO;
using Sunny.UI;
using S7.Models;
using System.Collections.Generic;
using S7.Helper;

namespace S7
{
    public partial class Form1 : UIForm
    {
        private List<DataGetModel> dataGetModels;
        private S7Helper s7Helper;

        public Form1()
        {
            InitializeComponent();
            InitData();
            //InitTempCycleThread();
            InitTempCycleAsync();
        }
        //实现循环读取温度
        //private void InitTempCycleThread()
        //{
        //    var thread = new Thread(() =>
        //    {
        //        while (true)
        //        {
        //            try
        //            {
        //                if (s7Helper != null&& s7Helper.Connected)
        //                {
        //                    var temputrue = s7Helper.ReadSingleData_Float(1, 4, 4, PlcDataType.Float);
        //                    Invoke(new Action(() =>
        //                    {
        //                        uiTemputrue.Value = temputrue;//inovke 有委托和控件两个可以使用，可以中断当前UI的线程，同时不会造成进程间混乱
        //                        //加action是可以在UI线程中增加你需要的操作

        //                    }));
        //                }

        //                Thread.Sleep(500);//作为传统的编程，sleep可以中断当前的UI定时操作，阻塞当前线程，不阻塞线程池--task.sleep两个都不阻塞，优选）
        //            }
        //            catch (Exception e)
        //            {
        //               HLog.Error("读取温度失败", e);
        //            }
        //        }
        //    });
        //    thread.Start();
        //}

        /// <summary>
        /// 异步读取 PLC 数据并更新 UI。
        /// </summary>
        /// <returns>异步任务。</returns>
        private async Task InitTempCycleAsync()
        {
            while (true)
            {
                try
                {
                    if (s7Helper != null && s7Helper.Connected)
                    {
                        var temperature = s7Helper.ReadSingleData_Float(1, 4, 4, PlcDataType.Float);
                        Invoke(new Action(() =>
                        {
                            uiTemputrue.Value = temperature;
                        }));
                    }

                    await Task.Delay(500);
                }
                catch (Exception ex)
                {
                    HLog.Error("读取温度失败", ex);
                }
            }
        }

        private void InitData()
        {
            try
            {
                var iniFilePath = AppDomain.CurrentDomain.BaseDirectory + "config.ini";
                IniFile ini = new IniFile(iniFilePath);
                string dataGetPath = ini.ReadString("Setup", "DataGetPath", "DataGet.xlsx");
                string dataSetPath = ini.ReadString("Setup", "DataSetPath", "DataGet.xlsx");

                using (var stream = File.OpenRead(AppDomain.CurrentDomain.BaseDirectory + dataGetPath))
                {
                    dataGetModels =
                        stream.Query<DataGetModel>()
                            .ToList(); //出了一个大问题， it can't cast to Int32 type，为什么可以使用AI来帮助解决，发现是读取类型没改用的INT 其实是string
                    gridPlc.DataSource = dataGetModels;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uiTurnSwitch1_ValueChanged(object sender, bool value)
        {
            if (uiTurnSwitch1.Active)
            {
                try
                {
                    s7Helper = new S7Helper("S71200", s7IP.Text);

                    var status = s7Helper.ConnectPLC(s7Port.Value, (short)s7Rack.Value, (short)s7Solt.Value);

                    s7Status.State = status ? UILightState.On : UILightState.Off;

                    var temputrue = s7Helper.ReadSingleData_Float(1, 4, 4, PlcDataType.Float);
                    
                    uiTemputrue.Value= temputrue;

                    MessageBox.Show("设备启动");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            else
            {
                    s7Status.State= UILightState.Off;
                    if (s7Helper!=null)
                    {
                        s7Helper.DisconnectPLC();
                        
                    }
                    MessageBox.Show("设备关闭");
            }

            
        }
    }
}
