using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_刘铁锰委托练习.模块化
{
    class Program
    {
        static void Main(string[] args)//主程序入口
        {
            IproductFactory pizzaFactory = new PizzaFactory();
            IproductFactory toyCarFactory = new ToyCarFactory();
            WrapFactory wrapFactory  = new WrapFactory();

            //Func<Product> func1 = new Func<Product>(product.MakePizza);//将做披萨这个步骤封装为func1
            //Func<Product> func2 = new Func<Product>(product.MakeToyCar);

            //Logger logger = new Logger();   
            //Action<Product> log=new Action<Product>(logger.Log);

            Box box1=wrapFactory.WrapProduct(pizzaFactory);
            Box box2 = wrapFactory.WrapProduct(toyCarFactory);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
        }

        //class Logger //log方法
        //{
        //    public void Log(Product product)//log是最常用的接口，一般不带返回值，用于读取()内容的运行状态
        //    {
        //        Console.WriteLine("Product‘{0}’created at{1}.Price is{2}.",product.Name,DateTime.UtcNow,product.Price);//utcNow是不带时区的
        //    }
        //}
        interface IproductFactory 
        {
            Product Make();
        }

        class PizzaFactory : IproductFactory
        {
            public Product Make()
            {
                Product product = new Product();
                product.Name = "Pizza";
                product.Price = 12;
                return product;
            }
        }class ToyCarFactory : IproductFactory
        {
            public Product Make()
            {
                Product product = new Product();
                product.Name = "Toy Car";
                product.Price = 100;
                return product;
            }
        }


        class Product //产品类
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
        class Box //盒子类
        {
            public Product Product { get; set; }
        }
        class WrapFactory //打包工厂
        {
            public Box WrapProduct(IproductFactory productFactory)
            //工厂需要接口类型的参数
            //public Box WrapProduct(Func<Product>getProduct,Action<Product>logCallback)
            //    //Func<委托内容/返回值>+委托名 在打包的方法中加入了委托 （）
            {
                Box  box= new Box();
                Product product =productFactory.Make();
                //Product product = getProduct.Invoke();//调用委托
                //if (product.Price >= 50)
                //{
                //    logCallback(product);
                //}
                box.Product = product;
                return box;
            }
        }

        //class ProductFactory //产品工厂
        //{
        //    public Product MakePizza()
        //    {
        //        Product product = new Product();
        //        product.Name = "Pizza";
        //        product.Price = 12;
        //        return product;
        //    }

        //    public Product MakeToyCar()
        //    {
        //        Product product = new Product();
        //        product.Name = "Toy Car";
        //        product.Price=100;
        //        return product;
        //    }
        //}

    }
} 


