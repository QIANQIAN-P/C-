using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_刘铁锰委托练习
{
    public delegate double Calc(double x, double y);//自定义委托 参数类型保持一致
    class 模块化举例
    {
        //public delegate double Calc(double x, double y);
        //自定义委托 在类里面称为嵌套委托，要加  类前缀.Calc
        static void Main(string[] args)
            {
            Cauclator cauclator = new Cauclator();
            Calc calc1 = new Calc(cauclator.Add);
            Calc calc2 = new Calc(cauclator.Sub);
            Calc calc3 = new Calc(cauclator.Mul);
            Calc calc4 = new Calc(cauclator.Div);
            double a = 100;
            double b = 200;
            double c=0;
            c = calc1(a, b);
            Console.WriteLine(c);
            c = calc2(a, b);
            Console.WriteLine(c);
            c = calc3(a, b);
            Console.WriteLine(c);
            c = calc4(a, b);
            Console.WriteLine(c);
            
        }

    } 
    class Cauclator
    {
            public double  Add(double a, double b)
            {
                return a + b;
            }

            public double Sub(double a, double b)
            {
                return a - b;
            }
            public double Mul(double a, double b)
            {
              
                return a * b;
            }

            public double Div(double a, double b)
            {
    
                return a / b;
            }
        }
}
