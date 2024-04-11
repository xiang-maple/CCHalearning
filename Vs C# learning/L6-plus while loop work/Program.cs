using System.Runtime.CompilerServices;

namespace L6_plus_while_loop_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //// review
            //int i = 0;
            //while (i < 100)
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //}
            //Random random = new Random();
            //while (true)
            //{
            //    int rand = random.Next(0, 100);
            //    Console.WriteLine("press any button to pick the game, if you want to end the game, please input end");
            //     string key = Console.ReadLine();
            //    if (key == "end")
            //    {
            //        break;
            //    }
            //    if (rand < 10)
            //    {
            //        Console.WriteLine("guanyu");
            //    }
            //    else if (rand < 30)
            //    {
            //        Console.WriteLine("liubei");
            //    }
            //    else if (rand < 60)
            //    {
            //        Console.WriteLine("huanzhong");
            //    }
            //    else
            //    {
            //        Console.WriteLine("zhangfei");
            //    }
            // homework
            int onum = 0;
            int cnum = 0;
            bool flag = true;
            while (flag)
            {
                onum++;
                cnum += onum;
                if (onum >= 100)
                {
                    flag = false;
                    Console.WriteLine($"the outcome of plus from 1 to 100 is {cnum}");

                }
            }
            Random num = new Random();
            int rand = num.Next(1, 101);
            int ti = 0;
            while (true)
            {
                ti++;
                Console.WriteLine("guess and input your number ");
                string innum = Console.ReadLine();
                int inum = int.Parse(innum);
                if (inum < rand)
                {
                    Console.WriteLine("number is lwo");
                }
            
                
                else if (inum > rand)
                {
                    Console.WriteLine("number is high");
                }


                else
                {
                    Console.WriteLine($"number is equal, the random is {rand}");
                    Console.WriteLine($"guess time is {ti}");
                    break;  
                }

            }


        }
    }
}
