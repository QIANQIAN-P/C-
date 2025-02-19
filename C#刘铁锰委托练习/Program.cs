namespace DelegateExample 
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Delegate KK=  new Delegate();
            Action _action = new Action(KK.Report);//委托第一种形式，action 函数直接调用
            //下面是action委托的三种表达方式
            KK.Report();
            _action.Invoke ();
            _action();

            //第二种，Func 函数间接调用
            Func<int ,int ,int>Func1 = new Func<int, int, int>(KK.Add);
            Func<int, int, int> Func2 = new Func<int, int, int>(KK.Sub);
            Console.WriteLine("请分别输入两个整数,用enter隔开");
            string? _x = Console.ReadLine();
            int.TryParse(_x, out int x);
            string? _y = Console.ReadLine();
            int.TryParse(_y, out int y);
            //int x = 100;
            //int y = 200;
            int z;
            z = Func1(x, y);
            Console.WriteLine( z);
            z = Func2(x, y);
            Console.WriteLine( z);

        }
    }

    class Delegate 
    {
        public void Report() 
        {
            Console.WriteLine("I have 3 chances.");
        }

        public int Add(int a,int b) 
        {
            int Result =a+ b;
            return Result ;
        }

        public int Sub(int a, int b)
        {
            int Result = a - b;
            return Result;
        }

    }





}
