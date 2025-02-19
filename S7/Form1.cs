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
        //ʵ��ѭ����ȡ�¶�
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
        //                        uiTemputrue.Value = temputrue;//inovke ��ί�кͿؼ���������ʹ�ã������жϵ�ǰUI���̣߳�ͬʱ������ɽ��̼����
        //                        //��action�ǿ�����UI�߳�����������Ҫ�Ĳ���

        //                    }));
        //                }

        //                Thread.Sleep(500);//��Ϊ��ͳ�ı�̣�sleep�����жϵ�ǰ��UI��ʱ������������ǰ�̣߳��������̳߳�--task.sleep����������������ѡ��
        //            }
        //            catch (Exception e)
        //            {
        //               HLog.Error("��ȡ�¶�ʧ��", e);
        //            }
        //        }
        //    });
        //    thread.Start();
        //}

        /// <summary>
        /// �첽��ȡ PLC ���ݲ����� UI��
        /// </summary>
        /// <returns>�첽����</returns>
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
                    HLog.Error("��ȡ�¶�ʧ��", ex);
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
                            .ToList(); //����һ�������⣬ it can't cast to Int32 type��Ϊʲô����ʹ��AI����������������Ƕ�ȡ����û���õ�INT ��ʵ��string
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

                    MessageBox.Show("�豸����");
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
                    MessageBox.Show("�豸�ر�");
            }

            
        }
    }
}
