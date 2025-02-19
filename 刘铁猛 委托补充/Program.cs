//namespace Combine
//{
//    class Program
//    {
//        static void Main(string[] args) 
//        {
//            MyDele<int> dele1 = new MyDele<int>(Add);
//            int res = dele1(100,200);
//            Console.WriteLine(res);
//            MyDele<double> dele2 = new MyDele<double>(Mul);
//            double res2 = dele2(100,200);
//            Console.WriteLine(res2);
//        }

//        static int Add(int x, int y)
//        {
//            return x + y;
//        }
//        static double Mul(double x, double y)
//        {
//            return x * y;
//        }

//        delegate T MyDele<T>(T a, T b);//自定义的泛型委托
//    }
//}