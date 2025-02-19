using System.Collections.Generic;
using System.Net;

namespace SerialPortPro.Models
{
    internal class Faker
    {
        public enum NetworkType
        {
            TcpServer,
            TcpClient,
            Udp,
            Modbus,
            WebSocket,
            Rpc,
            WebApi,
            JsonRpc
        }
        //IP固定写法
        public static List<string> GetIps()
        {
            var ips = new List<string>();
            ips.Add("127.0.0.1");
            foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ips.Add(ip.ToString());
                }
            }
            ips.Add("0.0.0.0");
            return ips;
        }
    }
}
