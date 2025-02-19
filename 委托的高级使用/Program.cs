namespace MulticastDelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID=1,PenColor=ConsoleColor.Yellow };
            Student stu2 = new Student() { ID=2,PenColor=ConsoleColor.Green };
            Student stu3 = new Student() { ID=3,PenColor=ConsoleColor.Red };
            //——————————————————————————————————————————
            //Action action1 = new Action(stu1.DoHomework);
            //Action action2 = new Action(stu2.DoHomework);
            //Action action3 = new Action(stu3.DoHomework);
            ////委托的不同执行顺序
            ////单播委托
            ////action1.Invoke();
            ////action2.Invoke();
            ////action3.Invoke();
            ////多播委托
            ////action1 += action2;
            ////action1 += action3;
            ////action1.Invoke();//按封装的顺序来执行
            //——————————————————————————————————————————
            ////同步调用:一件事情做完做下一件事情
            //stu1.DoHomework();//直接同步调用
            //stu2.DoHomework();//！！！直接间接和同步异步是不相干的
            //stu3.DoHomework();

            //for (int i = 0; i < 10; i++) //进程调用
            //{
            //    Console.ForegroundColor = ConsoleColor.Cyan;
            //    Console.WriteLine("Main Thread{0}",i);
            //    Thread.Sleep(100);
            //}  
            //——————————————————————————————————————————
            //异步调用：同时进行
            Action action1 = new Action(stu1.DoHomework);
            Action action2 = new Action(stu2.DoHomework);
            Action action3 = new Action(stu3.DoHomework);

            Task task1 = new Task(new Action(stu1.DoHomework));//task开启一个分支进程~多线程
            Task task2 = new Task(new Action(stu2.DoHomework));//task开启一个分支进程~多线程
            Task task3 = new Task(new Action(stu3.DoHomework));//task开启一个分支进程~多线程
           
            task1.Start();
            task2.Start();
            task3.Start();

            for (int i = 0; i < 10; i++) //进程调用
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Main Thread{0}", i);
                Thread.Sleep(1000);
            }
        }


    }

    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomework()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student{0} doing homework{1} hour(s).", this.ID, i);
                Thread.Sleep(1000);
            }
        }
    }
}
                    