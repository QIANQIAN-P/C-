<Query Kind="Program">
  <Namespace>System.Net.Sockets</Namespace>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>LINQPad.FSharpExtensions</Namespace>
</Query>

void Main()
{
	var tcpListener= new TcpListener(IPAddress.Parse("127.0.0.1"),9995);
	tcpListener.Start();
	"start".Dump();
	Task.Run(async() => {
	var tcpClient=await tcpListener.AcceptTcpClientAsync();
	"lianshang".Dump();//要有这两句话才算连接上，三次握手
	});
}


