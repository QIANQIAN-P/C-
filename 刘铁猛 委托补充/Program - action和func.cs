using System;

//namespace Combine
//{
//    class Program
//    {
//        static void Main(string[] args) 
//        {
//            Action action = new Action(M1);
//            action.Invoke();//不带参数
//            Action<string> action1 = new Action<string>(SayHello);
//            action1("Tim");//带参数
//            Action<string,string> action2 = new Action<string,string>(SayHello1);
//            action2("Tim","Tom");//带多个相同类型的参数
//            Action<string,int> action3 = new Action<string,int>(SayHello2);
//            action3("Tim",3);//带多个不同类型的参数
//            //-------------------------------------------------------------------------
//            Func<int, int, int> func = new Func<int, int, int>(Add);
//            int res= Add(100,200);//带返回值
//            Console.WriteLine(res);
//            Func<double, double, double> func1 = new Func<double, double, double>(Mul);
//            var res1 = Mul(3.0, 4.0);
//            Console.WriteLine(res1);


//        }
//        static void M1()
//            {
//            Console.WriteLine("M1 is called.");
//            }
//        static void SayHello(string name) 
//        {
//            Console.WriteLine($"Hello,{ name}!");
//        }
//        static void SayHello1(string name1,string name2) 
//        {
//            Console.WriteLine($"Hello,{ name1} and {name2}!");
//        }
//        static void SayHello2(string name,int round) 
//        {
//            for (int j = 0; j < round; j++) 
//            {
//                Console.WriteLine($"Hello,{name}!");
//            }
//        }
//        static int Add(int x, int y)
//        {
//            return x + y;
//        }
//        static double Mul(double x, double y)
//        {
//            return x * y;
//        }
             
//    }
//}