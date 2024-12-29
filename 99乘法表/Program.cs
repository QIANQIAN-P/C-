class Program //定义一个名为Program的类
{
    static void Main(string[] args)//定义一个静态的主方法（函数）
    {

        for (int i = 1; i < 10; i++)//外层循环，遍历1到9之间的函数
        {
            for (int j = 1; j <= i; j++)//内层循环，遍历1到i之间的函数
            {
                Console.Write("{0}*{1}={2}\t",j,i,i*j);//输出乘法表达式加空格,不换行
            }
            Console.WriteLine();//内层循环结束后，换行
        }
    }
}