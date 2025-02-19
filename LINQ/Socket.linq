<Query Kind="Program">
  <Namespace>System.Net.Sockets</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()//async 是隐式异步,返回promis函数
{
	var cts =new CancellationTokenSource();//取消令牌源
	var socket=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
	socket.Connect("127.0.0.1",9999);
	
    var buffer=new byte[1024];

	var thread = new System.Threading.Thread(() => {
	Thread.Sleep(100000);
	cts?.Cancel();
	socket?.Close();
	});
	thread.Start();

	//await socket.ReceiveAsync(buffer);
	while(!cts.Token.IsCancellationRequested)
	{
		try
		{
			await socket.SendAsync(Encoding.UTF8.GetBytes($"Hi Bob {DateTime.Now}"));
			//await和async配合使用，必须要await后面的执行完以后才能执行别的东西
		    var receivedBytes = await socket.ReceiveAsync(new ArraySegment<byte>(buffer));
			Encoding.UTF8.GetString(buffer,0,receivedBytes).Dump();
			await socket.ReceiveAsync(buffer);
			await Task.Delay(2000);
		}
		catch(Exception ex)
		{
			ex.Dump();
		}
			
	}
	socket?.Close();
}


