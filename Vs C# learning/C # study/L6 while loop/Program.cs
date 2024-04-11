using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

namespace L6_while_loop
{
    internal class Program
    {
        static void test(int count)
        {
            // ues while loop to calculate the accumlation from 1 to 100
            int j = 0;
            int i = 0;
            bool flag = true;
            while (flag)
            {
                i++;
                j += i;

                if (i >= count)
                {

                    flag = false;

                }



            }
            Console.WriteLine(j);

        }
        static void cardpick(int r1, int r2, int r3)
        {
            // pick card 
            // form random
            Random randomm = new Random();  // NOT . 
            Console.WriteLine("card pick game begin");
            Console.WriteLine("if you want to over the game please input 'end'");
            bool flag = true;
            // card pick loop
            while (flag)
            {
                Console.WriteLine("press any button to gain card");
                int card = randomm.Next(0, 101);
                string btn = Console.ReadLine();
                if (card <= r1)
                {
                    Console.WriteLine("guangyu");
                }
                else if (card <= r2)
                {
                    Console.WriteLine("zhaoyun");
                }
                else if (card <= r3)
                {
                    Console.WriteLine("zhangfei");
                }
                else
                {
                    Console.WriteLine("huanzhong");
                }

                btn = btn.Trim();
                if (btn == "end")
                {
                    flag = false;
                }
            }
            Console.WriteLine("game over");

        }
        static void numguess(int num)
        {
            // guess number 
            Random random = new Random();
            int rand = random.Next(1, 101);

            Console.WriteLine("input your number");
            //string input = Console.ReadLine();
            //int num = Convert.ToInt32(input);
            if (num > rand)
            {
                Console.WriteLine("high");

            }
            else if (num < rand)
            {
                Console.WriteLine("low");

            }
            else
            {

                Console.WriteLine($"win, the number is {rand}");
            }

        }
        static void Main(string[] args)
        {
            numguess(10);
            test(10);
        }
    }
}
