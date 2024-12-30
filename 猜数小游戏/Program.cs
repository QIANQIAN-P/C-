namespace 猜数
{
    public class BullsAndCows
    {
        static void Main(string[] args)
        {//1.标题界面
            Console.WriteLine("您已受邀加入猜数小游戏环节,请输入Y进入游戏环节");
            if ("Y" == Console.ReadLine())
            {
                StartGame();
                RangeGame();
            }
            else 
            {
                Console.WriteLine("输入字符不符合要求，游戏结束");
            }
        }
        static void StartGame()
        {
            //2.提示输入字符
            Console.WriteLine("请在下方输入最大值和最小值，中间用英文逗号隔开");
            Console.WriteLine();
        }
        static void RangeGame()
        {
            //3.检测范围是否符合要求,并排范围大小
            string? input = Console.ReadLine();
            if (input == null)//检测是否为空值
            {
                Console.WriteLine("输入字符不符合要求，请重新输入");
                //Console.WriteLine();
                RangeGame();
            }
            else
            {
                string[] range = input.Split(",");//xx.Split 返回指定字符分隔的子字符串 aabb->aa,bb 也算是数组
                if (range.Length != 2)//XX.Length 算数组中有几个子字符串，检测是否是两个
                {
                    Console.WriteLine("输入字符不符合要求，请重新输入");
                    RangeGame();
                }
                else
                {
                    if (!int.TryParse(range[0], out int Min) ||
                        !int.TryParse(range[1], out int Max))//如果两个中有一个不能转化为数字
                    {
                        Console.WriteLine("输入字符不符合要求，请重新输入");
                        RangeGame();
                    }
                    else
                    {
                        if (Min > Max)
                        {
                            int Tmp = Min;
                            Max = Min;
                            Min = Tmp;
                        }
                        int target = new Random().Next(Min, Max);
                        int? guess = null;
                        //4.进入猜数环节
                        do
                        {
                            Console.WriteLine("请在以下范围内猜出准确的数字");
                            Console.WriteLine();
                            input = Console.ReadLine();//借用上文的input
                            int.TryParse(input, out int a);
                            guess = a;
                            if (target == guess)
                            {
                                Console.WriteLine("恭喜你猜中了");
                            }
                            else
                            {
                                if (guess > target)
                                {
                                    Console.WriteLine("恭喜你猜大了");
                                }
                                else
                                {
                                    Console.WriteLine("恭喜你猜小了");
                                }

                            }
                        }
                        while (guess != target);
                    }

                }

            }

        }
      }
    
}

