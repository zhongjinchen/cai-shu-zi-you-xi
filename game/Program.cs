using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
            int max = 100;
            int random = new Random().Next(max);
            int input = 0;

            bool sucesss = false;

            for (int i = 0; i < 10;i++)
            {
                Console.WriteLine("请输入一个数:");
                string strInput = Console.ReadLine();
                input = Convert.ToInt32(strInput);

                if (input == random)
                {
                    Console.WriteLine("回答正确");
                    sucesss = true;
                    break;

                }
                else if (input > random)
                {
                    Console.WriteLine($"第{i + 1}次比较，数字大了");
                }
                else
                {
                    Console.WriteLine($"第{i + 1}次比较，数字小了");
                }

            }

            if (!sucesss)
            {
                Console.WriteLine("蠢死了");

            }
            Console.Read();
        }
    }
}
