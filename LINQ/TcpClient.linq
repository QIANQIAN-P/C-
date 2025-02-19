<Query Kind="Program">
  <Namespace>System.Net.Sockets</Namespace>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

 void Main()
{
	var tcpClient=new TcpClient();
	tcpClient.Connect(IPAddress.Parse("127.0.0.1"),9995);
	"连接2成功".Dump();
	var networkStream=tcpClient.GetStream();
	networkStream.Write(Encoding.UTF8.GetBytes("Hi 12312312"));
	Task.Run(async() =>
	{
		while (networkStream.CanRead)
		{
			var buffer=new byte[1024*1024];
			var readLen=networkStream.Read(buffer);
			Encoding.UTF8.GetString(buffer,0,readLen).Dump();
			//要加DUMP把结果抛出来
		}
	
	});
	
}