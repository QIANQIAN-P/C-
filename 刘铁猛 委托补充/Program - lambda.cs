//namespace Combine {
//    class Program {
//        static void Main(string[] args)
//        {
//            //Lambda
//            //1.匿名方法 -不要新声明一个方法，直接在原函数/方法上建立委托
//            //2.Inline方法-与方法本身内联，不用重写方法再做委托调用，简化代码
//            //int res = Add(100, 200);//非Inline方法，调用add方法
//            //——————————————————————————————————————————————————————
//            //用Inline方法,不新建方法
//            Func<int, int, int> func = new Func<int, int, int>((int a, int b) => { return a + b; });
//            //(int a, int b) => { return a + b; }就是Lambma表达式,与方法内联
//            int res = func(100, 200);
//            Console.WriteLine(res);
//            func = new Func<int, int, int>((int x, int y) => { return x*y; });
//            int res1= func(3,4);
//            Console.WriteLine(res1);
//            //——————————————————————————————————————————————————————
//            //简化
//            //第一：同一个函数，参数类型一直可以省略Lambda内的参数类型
//            //Func<int, int, int> func = new Func<int, int, int>((a, b) => { return a + b; });
//            //第二：简化委托实例的创建
//            //Func<int, int, int> func = ((a,b) => { return a + b; });
//            //第三：Lambda表达式((a,b) => { return a + b; })作为实参赋给形参func
//            //func = ((a, b) => { return a + b; });


//        }

//        //static int Add(int a,int b) 
//        //{
//        //    return a + b;
//        //}
//    }
//}













namespace Combine
{
    class Program
    {
        //泛型方法加泛型委托加泛型参数推断加Lambda表达式
        static void Main(string[] args)
        {
            //DOSomeCalc <int>((a, b) => { return a * b; },100,200);
            //泛型参数推断:根据你输入数据的类型自动生成方法的参数类型，所以省略int
            DOSomeCalc((a, b) => { return a * b; },100,200);
            //其次：(a, b) => { return a * b; }==Func<T, T, T> func
            //100,200==T x, T y
        }
        static void DOSomeCalc<T>(Func<T, T, T> func, T x, T y) //泛型委托
        {
            T res = func(x, y);
            Console.WriteLine(res);
        }
    }
}
