using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace L10_function
{
    internal class Program
    {


        //static void Main(string[] args)
        //{


        //    Console.WriteLine($"please input the 1 number");
        //    int a = numinp();
        //    Console.WriteLine($"please input the 2 number");
        //    int b = numinp();
        //    Console.WriteLine($"please input the 3 number");
        //    int c = numinp();
        //    int sum = sftrum(a, b, c);
        //    Console.WriteLine($"that is my answer of sum of three number {sum}");


        //    Console.WriteLine("Hello, World!");
        //}

        

        // contrast the two number and the outcome
        static void Main(string[] args)
        {
            int a = crrand();
            while (true)
            {

                int b = input();
                if (a > b)
                {
                    Console.WriteLine("your answer is less than the random, please inputa again");
                }
                else if (a < b)
                {
                    Console.WriteLine("your answer is bigger than the random, please inputa again");
                }
                else
                {
                    Console.WriteLine("your answer is equal to the random, the game is over");
                    break;
                }
            }
        }















































        static int numinp()
        {
            Console.WriteLine("please input a number");
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);
            Console.WriteLine("---------------------");
            return a;
        }
        static int sftrum(int a, int b, int c)
        {

            return a + b + c;
        }










        // input a number 
        static int input()
        {
            string s = Console.ReadLine();
            int i = Convert.ToInt32(s);


            return i;

        }



        // get the rangom number
        static int crrand()
        {
            Random rand = new Random();
            int rd = rand.Next(0, 100);
            return rd;

        }
    }
}
