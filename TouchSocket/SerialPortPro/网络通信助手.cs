using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Masuit.Tools;
using SerialPortPro.Helper;
using TouchSocket.Core;
using TouchSocket.Sockets;
using static SerialPortPro.Models.Faker;
using TcpClient = TouchSocket.Sockets.TcpClient;


namespace SerialPortPro
{
    public partial class 网络通信助手 : DevExpress.XtraEditors.XtraForm
    {
        private bool _isOpen = false;
        private string logFilePath = "";
        private bool _isCycle = false;
        private Thread CycleThread;
        private string _selectPortName;
        private TcpClient tcpClient = new TcpClient();
        private UdpSession udpService = new UdpSession();
        private TcpService tcpService = new TcpService();

        public 网络通信助手()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            comboBoxEditType.Properties.Items.AddRange(Enum.GetValues(typeof(NetworkType)));
            comboBoxEditIP.Properties.Items.AddRange(GetIps());

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                // 获取当前选中的 NetworkType 枚举值
                if (Enum.TryParse(comboBoxEditType.SelectedItem.ToString(), out NetworkType selectedType))
                {
                    switch (selectedType)
                    {
                        case NetworkType.TcpServer:
                            StartTcpServer();
                            break;
                        case NetworkType.TcpClient:
                            StartTcpClient();
                            break;
                        case NetworkType.Udp:
                            StartUdp();
                            break;
                        default:
                            throw new NotSupportedException("Selected network type is not supported.");
                    }
                }
                else
                {
                    throw new InvalidOperationException("Invalid selection in comboBoxEditType.");
                }
            }
            catch (Exception exception)
            {
                btnOpen.Text = "打开";
                memoEditlog.AppendText(exception.Message + Environment.NewLine);
            }
        }

        private void StartTcpClient()
        {
            if (_isOpen)
            {
                tcpClient.Close();
                btnOpen.Text = "打开";
                ChangeCombeEnable(true);
                memoEditlog.AppendText("连接关闭".FormatStringLog());
            }
            else
            {
                tcpClient.Connecting = (client, args) =>
                {
                    Invoke(new Action(() =>
                    {
                        memoEditlog.AppendText($"{client.IP}:{client.Port} 正在连接服务器".FormatStringLog());
                    }));
                    return TouchSocket.Core.EasyTask.CompletedTask;
                };
                tcpClient.Connected = (client, args) =>
                {
                    Invoke(new Action(() =>
                    {
                        memoEditlog.AppendText($"{client.IP}:{client.Port} 客户端连接成功".FormatStringLog());
                    }));
                    return EasyTask.CompletedTask;
                };
                tcpClient.Disconnecting = (client, args) =>
                {
                    // 只有当主动断开时才有效
                    Invoke(new Action(() =>
                    {
                        memoEditlog.AppendText($"{client.IP}:{client.Port} 客户端正在断开连接".FormatStringLog());
                    }));
                    return EasyTask.CompletedTask;
                };
                tcpClient.Disconnected = (client, args) =>
                {
                    Invoke(new Action(() =>
                    {
                        memoEditlog.AppendText($"{client.IP}:{client.Port} 客户端断开连接".FormatStringLog());
                    }));
                    return EasyTask.CompletedTask;
                };
                tcpClient.Received = (client, args) =>
                {
                    // 从客户端收到信息:注意：数据长度是byteBlock.Len
                    var mes = Encoding.UTF8.GetString(args.ByteBlock.Buffer, 0, args.ByteBlock.Len);
                    client.Logger.Info($"已从{client.IP}:{client.Port} 接收到信息：{mes}");

                    if (checkEditRecAscii.Checked)
                    {
                        Invoke(new Action(() =>
                        {
                            memoEditlog.AppendText($"已从{client.IP}:{client.Port}接收到信息：{mes}".FormatStringLog());
                        }));
                    }
                    else
                    {
                        Invoke(new Action(() =>
                        {
                            memoEditlog.AppendText($@"已从{client.IP}:{client.Port}接收到信息：{string.Join(" ", args.ByteBlock.Buffer.Take(args.ByteBlock.Len).Select(b => b.ToString("X2")).ToArray())}"
                                .FormatStringLog());
                        }));
                    }

                    // 将收到的信息直接返回给发送方
                    client.Send($"已收到信息：{mes}");

                    return EasyTask.CompletedTask;
                };

                var ip = comboBoxEditIP.Text;
                var port = textEditPort.Text.ToInt32();

                tcpClient.Setup(new TouchSocketConfig()//载入配置
                    .SetRemoteIPHost($"{ip}:{port}")//同时监听两个地址
                    .ConfigureContainer(a =>//容器的配置顺序应该在最前面
                    {
                        a.AddConsoleLogger();//添加一个控制台日志注入（注意：在maui中控制台日志不可用）
                    })
                    .ConfigurePlugins(a =>
                    {
                        // 开启断线重连
                        // 如需永远尝试连接，tryCount 设置为 -1 即可。
                        a.UseReconnection(5, true, 1000);
                    }));

                tcpClient.Connect();//启动
                tcpClient.Send("已连接");

                ChangeCombeEnable(false);
                btnOpen.Text = "关闭";
                memoEditlog.AppendText("连接打开".FormatStringLog());
            }

            _isOpen = !_isOpen;
            ChangeEditLastend();
        }

        private void StartUdp()
        {
            if (_isOpen)
            {
                udpService.Stop();
                btnOpen.Text = "打开";
                ChangeCombeEnable(true);
                memoEditlog.AppendText("连接关闭".FormatStringLog());
            }
            else
            {
                var port = textEditPort.Text.ToInt32();

                udpService.Received = (c, e) =>
                {
                    Invoke(new Action(() =>
                    {
                        memoEditlog.AppendText($"已从{c.RemoteIPHost}接收到信息：{Encoding.UTF8.GetString(e.ByteBlock.Buffer, 0, e.ByteBlock.Len)}".FormatStringLog());
                    }));

                    return EasyTask.CompletedTask;
                };
                udpService.Setup(new TouchSocketConfig()
                    .SetBindIPHost(new IPHost(port)));
                udpService.Start();
                ChangeCombeEnable(false);
                btnOpen.Text = "关闭";
                memoEditlog.AppendText("连接打开".FormatStringLog());
            }

            _isOpen = !_isOpen;
            ChangeEditLastend();
        }

        private void StartTcpServer()
        {
            if (_isOpen)
            {
                tcpService.Stop();
                btnOpen.Text = "打开";
                ChangeCombeEnable(true);
                memoEditlog.AppendText("连接关闭".FormatStringLog());
            }
            else
            {
                tcpService.Connecting = (client, args) =>
                {
                    Invoke(new Action(() =>
                    {
                        memoEditlog.AppendText($"正在连接{client.IP}:{client.Port} 客户端".FormatStringLog());
                    }));
                    return EasyTask.CompletedTask;
                };
                tcpService.Connected = (client, args) =>
                {
                    Invoke(new Action(() =>
                    {
                        memoEditlog.AppendText($"{client.IP}:{client.Port} 客户端连接成功".FormatStringLog());
                    }));
                    return EasyTask.CompletedTask;
                };
                tcpService.Disconnecting = (client, args) =>
                {
                    // 只有当主动断开时才有效
                    Invoke(new Action(() =>
                    {
                        memoEditlog.AppendText($"{client.IP}:{client.Port} 客户端正在断开连接".FormatStringLog());
                    }));
                    return EasyTask.CompletedTask;
                };
                tcpService.Disconnected = (client, args) =>
                {
                    Invoke(new Action(() =>
                    {
                        memoEditlog.AppendText($"{client.IP}:{client.Port} 客户端断开连接".FormatStringLog());
                    }));
                    return EasyTask.CompletedTask;
                };
                tcpService.Received = (client, args) =>
                {
                    // 从客户端收到信息:注意：数据长度是byteBlock.Len
                    var mes = Encoding.UTF8.GetString(args.ByteBlock.Buffer, 0, args.ByteBlock.Len);
                    client.Logger.Info($"已从{client.IP}:{client.Port} 接收到信息：{mes}");

                    if (checkEditRecAscii.Checked)
                    {
                        Invoke(new Action(() =>
                        {
                            memoEditlog.AppendText($"已从{client.IP}:{client.Port}接收到信息：{mes}".FormatStringLog());
                        }));
                    }
                    else
                    {
                        Invoke(new Action(() =>
                        {
                            memoEditlog.AppendText($@"已从{client.IP}:{client.Port}接收到信息：{string.Join(" ", args.ByteBlock.Buffer.Take(args.ByteBlock.Len).Select(b => b.ToString("X2")).ToArray())}"
                                .FormatStringLog());
                        }));
                    }

                    // 将收到的信息直接返回给发送方
                    client.Send($"已收到信息：{mes}");

                    return EasyTask.CompletedTask;
                };

                var ip = comboBoxEditIP.Text;
                var port = textEditPort.Text.ToInt32();

                tcpService.Setup(new TouchSocketConfig()//载入配置
                    .SetListenIPHosts($"tcp://{ip}:{port}")//同时监听两个地址
                    .ConfigureContainer(a =>//容器的配置顺序应该在最前面
                    {
                        a.AddConsoleLogger();//添加一个控制台日志注入（注意：在maui中控制台日志不可用）
                    })
                    .ConfigurePlugins(a =>
                    {
                        // 开启断线重连
                        // 如需永远尝试连接，tryCount 设置为 -1 即可。
                        a.UseReconnection(5, true, 1000);
                    }));

                tcpService.Start();//启动

                ChangeCombeEnable(false);
                btnOpen.Text = "关闭";
                memoEditlog.AppendText("连接打开".FormatStringLog());
            }

            _isOpen = !_isOpen;
            ChangeEditLastend();
        }

        private void ChangeCombeEnable(bool enable)
        {
            comboBoxEditType.Enabled = enable;
            comboBoxEditIP.Enabled = enable;

        }

        private void checkEditRecLog_CheckedChanged(object sender, EventArgs e)
        {
            StringException.checkEditRecLog = checkEditRecLog.Checked;//打开时间戳
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
                    btnSend.Text = "发送";
                }
                else
                {
                    if (checkEditSendCycle.Checked)//用多线程制作循环启动和停止
                    {
                        CycleThread = new Thread(() =>
                        {
                            while (_isCycle)
                            {
                                SendMessageFromSeverice(result);
                                Thread.Sleep(textEditSendCycle.Text.ToInt32());
                            }
                        });
                        CycleThread?.Start();
                        _isCycle = true;
                        ChangeSendCombeEnable(false);
                        btnSend.Text = "停止发送";

                    }
                }
                SendMessageFromSeverice(result);
            }
        }

        private void ChangeSendCombeEnable(bool enable)//这一步.Enable 和.Checked 的区别
        {
            checkEditSendAscii.Enabled = enable;
            checkEditSendCycle.Enabled = enable;
            checkEditSendHex.Enabled = enable;
            checkEditSendRandom.Enabled = enable;
        }

        private void SendMessageFromSeverice(string result)
        {
            Invoke(new Action(() =>
            {
                if (checkEditSendAscii.Checked)
                {
                    memoEditlog.AppendText(result.FormatStringLog());
                    if (comboBoxEditType.Text == "TcpServer")
                    {

                    }
                    else
                    {
                        tcpClient.Send(result);
                    }
                }

            }));
        }



        //转16进制还有问题
        private byte[] TranStrToHexByte(string hexString)//关于静态变量和非静态变量的区别
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
                    logFilePath = saveFileDialog.FileName;
                }
            }
            checkEditRecFile.Checked = false;
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

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
