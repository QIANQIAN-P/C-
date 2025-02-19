using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using Masuit.Tools;
using SerialPortPro.Helper;
using SerialPortPro.Models;



namespace SerialPortPro
{
    public partial class 串口通信助手 : DevExpress.XtraEditors.XtraForm
    {
        private bool _isOpen = false;
        private string logFilePath="";
        private bool _isCycle=false;
        private Thread CycleThread;
        private string _selectPortName;

        public 串口通信助手()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            comboBoxEditPort.Properties.Items.AddRange(Faker.GetPort());
            comboBoxEditStopBit.Properties.Items.AddRange(Enum.GetValues(typeof(StopBits)));
            comboBoxEditParity.Properties.Items.AddRange(Enum.GetValues(typeof(Parity)));

            comboBoxEditPort.Text = "COM1";
            comboBoxEditBaund.Text = "115200";
            comboBoxEditParity.Text = "None";
            comboBoxEditDataBit.Text = "8";
            comboBoxEditStopBit.SelectedIndex = 1;
        }

        //标准写法
        protected override void WndProc(ref Message m)//重写 WndProc 方法以拦截和处理窗口消息。防止信息处理的冲突
        {
            string[] ports = new string[] { };

            //1.设备改变
            if (m.Msg == 0x0219)
            {
                //2.设备已拔出
                if (m.WParam.ToInt32() == 0x8004)
                {

                    //2.1 消息提醒
                   memoEditlog.AppendText("设备已拔出!".FormatStringLog());

                    //2.2 重新获取串口
                    ports = System.IO.Ports.SerialPort.GetPortNames();
                    comboBoxEditPort.Properties.Items.Clear();
                    comboBoxEditPort.Properties.Items.AddRange(ports);
                }
                // 3. 设备已连接
                else if (m.WParam.ToInt32() == 0x8000)
                {
                    memoEditlog.AppendText("设备已连接!".FormatStringLog());
                    ports = System.IO.Ports.SerialPort.GetPortNames();
                    comboBoxEditPort.Properties.Items.Clear();
                    comboBoxEditPort.Properties.Items.AddRange(ports);
                }

                //2 处理用户串口
                if (_isOpen)
                {
                    if (!ports.Contains(_selectPortName))
                    {
                        //2.3.1 释放掉原先的串口资源
                        serialPort1?.Close();
                        serialPort1?.Dispose();
                        //2.3.2 断开连接，改变按钮文字
                        btnOpen.Text = "打开";
                        ChangeCombeEnable(true);
                        comboBoxEditPort.SelectedIndex = comboBoxEditPort.Properties.Items.Count > 0 ? 0 : -1;
                    }
                    else
                    {
                        comboBoxEditPort.SelectedIndex = comboBoxEditPort.Properties.Items.IndexOf(_selectPortName);
                    }
                }

                ChangeEditLastend();
            }
            base.WndProc(ref m);//为了确保所有未被子类处理的消息能够按照正常流程继续处理，按照消息队列来走
        }

        //点击打开按钮，把框内的文本数据传到串口里面
        private void btnOpen_Click(object sender, EventArgs e)
        {
            //处理可能出现的各种异常情况，如权限不足、端口不存在等。
            try
            {
                if (_isOpen)
                {
                    serialPort1?.Close();
                    btnOpen.Text = "打开";
                    ChangeCombeEnable(true);
                    memoEditlog.AppendText(StringException.FormatStringLog("连接关闭"));
                }
                else
                {
                    //端口号，波特率，数据位都是给定的：端口号确定是哪一个端口，波特率决定传输速度，数据位决定一段报文传输多少位数据
                    serialPort1.PortName = comboBoxEditPort.Text;
                    serialPort1.BaudRate = comboBoxEditBaund.Text.ToInt32();
                    serialPort1.DataBits = comboBoxEditDataBit.Text.ToInt32();
                    //校验位是校验一段报文是否失真，停止位是数据位结束后与下一段做分割
                    //用枚举是枚举确保变量只能取预定义的值之一，减少了运行时错误的可能性等具体问AI，校验位和停止位比较重要且内容不多
                    if (Enum.TryParse(comboBoxEditStopBit.Text, out StopBits stopBits))//尝试将 comboBoxEditStopBit 的文本值解析为 StopBits 枚举类型
                    {
                        if (stopBits != StopBits.None)
                        {
                            serialPort1.StopBits = stopBits;
                        }
                    }
                    if (Enum.TryParse(comboBoxEditParity.Text, out Parity parity))
                    {
                        serialPort1.Parity = parity;
                    }
                    serialPort1?.Open();//使用空条件运算符 ?. 确保只有在 serialPort1 不为空时才调用 Open 方法
                    btnOpen.Text = "关闭";
                    ChangeCombeEnable(false);
                    memoEditlog.AppendText(StringException.FormatStringLog("连接打开"));
                }
                _isOpen = !_isOpen;
            }
            catch (Exception exception)
            {
                btnOpen.Text = "打开";
                memoEditlog.AppendText(exception.Message.FormatStringLog());

            }

        }

        private void ChangeCombeEnable(bool enable)
        {
            comboBoxEditPort.Enabled = enable;
            comboBoxEditBaund.Enabled = enable;
            comboBoxEditParity.Enabled = enable;
            comboBoxEditDataBit.Enabled = enable;
            comboBoxEditStopBit.Enabled = enable;
        }

        private void checkEditRecLog_CheckedChanged(object sender, EventArgs e)
        {
            StringException.checkEditRecLog = checkEditRecLog.Checked;//打开时间戳
        }
        //从SerialPort1中添加事件
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)//这是写的一个事件：新建一个相同长度的数组，把值复制到日志里面去
        {
            var len = serialPort1.BytesToRead;//查询字符串长度
            var buffers = new byte[len];//建立所需字符串的数组
            serialPort1.Read(buffers, 0, len);//读值
            string data = Encoding.UTF8.GetString(buffers);//写值，将字符串的值转化成一段段8位的字符串
            Invoke(new Action(() =>
            {
                if (checkEditRecAscii.Checked)
                {
                    memoEditlog.AppendText(data.FormatStringLog());//建立一个委托输出值
                }
                else
                {
                    memoEditlog.AppendText(string.Join(" ", buffers.Select(b => b.ToString("X2")).ToArray()).FormatStringLog());//转化成16进制
                }

            }));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            memoEditlog.Text = " ";
        }
        //发送按钮实现 随机数和循环发送
        private void btnSend_Click(object sender, EventArgs e)
        {
            var result = memoEditSendLog.Text;
            if (result.Length > 0)
            {
                if (checkEditSendRandom.Checked)
                {
                    result += new Random().Next(1, 999).ToString();
                }

                if (_isCycle)
                {
                    CycleThread?.Abort();
                    _isCycle = false;
                    ChangeSendCombeEnable(true); 
                    btnSend.Text ="发送" ;
                }
                else
                {
                    if (checkEditSendCycle.Checked)//用多线程制作循环启动和停止
                    {
                        CycleThread = new Thread(() => {
                            while (_isCycle)
                            {
                                SendMessage2Port(result);
                                Thread.Sleep(textEditSendCycle.Text.ToInt32());
                            }
                        });
                        CycleThread?.Start();
                        _isCycle = true;
                        ChangeSendCombeEnable(false);
                        btnSend.Text = "停止发送";

                    }
                }
                SendMessage2Port(result);
            }
        }

        private void ChangeSendCombeEnable(bool enable)//这一步.Enable 和.Checked 的区别
        {
            checkEditSendAscii.Enabled = enable;
            checkEditSendCycle.Enabled = enable;
            checkEditSendHex.Enabled = enable;
            checkEditSendRandom.Enabled = enable;
        }

        private void SendMessage2Port(string result)
        {
            Invoke(new Action(() =>
            {
                if (checkEditSendAscii.Checked)
                {
                    memoEditlog.AppendText(result.FormatStringLog());
                    serialPort1.Write(result);
                }
                else
                {
                    byte[] sendBytes = TranStrToHexByte(result);
                    if (sendBytes!=null)
                    {
                        /*memoEditSendLog写错了，东西一直留在发送窗口*/
                        memoEditlog.AppendText(string.Join(" ", sendBytes.Select(b => b.ToString("X2")).ToArray()).FormatStringLog());
                        serialPort1.Write(sendBytes, 0, sendBytes.Length);
                    }
                    
                }
            }));
        }

      

        //转16进制还有问题
        private  byte[] TranStrToHexByte(string hexString)//关于静态变量和非静态变量的区别
                                                          //private static byte[] TranStrToHexByte(string hexString)
        {
            int i;
            hexString = hexString.Replace(" ", "");//清除空格
            if ((hexString.Length % 2) != 0)//奇数个
            {
                byte[] returnBytes = new byte[(hexString.Length + 1) / 2];

                try
                {
                    for (i = 0; i < (hexString.Length - 1) / 2; i++)
                    {
                        returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                    }
                    returnBytes[returnBytes.Length - 1] = Convert.ToByte(hexString.Substring(hexString.Length - 1, 1).PadLeft(2, '0'), 16);
                }
                catch
                {
                    memoEditlog.AppendText("含有非16进制字符".FormatStringLog());
                    return null;
                }

                return returnBytes;
            }
            else
            {
                byte[] returnBytes = new byte[(hexString.Length) / 2];
                try
                {
                    for (i = 0; i < returnBytes.Length; i++)
                    {
                        returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                    }
                }
                catch
                {
                    memoEditlog.AppendText("含有非16进制字符".FormatStringLog());
                    return null;
                }
                return returnBytes;
            }
        }
        //文件保存
        private void checkEditRecFile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditRecFile.Checked)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    logFilePath= saveFileDialog.FileName;
                }
            }
            checkEditRecFile.Checked= false;
        }
        //自动定位及滚动
        private void ChangeEditLastend()
        {
            if (checkEditRecFile.Checked)
            {
                memoEditlog.SelectionStart = memoEditlog.Text.Length;
                memoEditlog.ScrollToCaret();
            }
        }
    }
}
