using System.ComponentModel.Design;

namespace L5__condition_sentence
{/*
    1. only if format
    2. if and else if and else format
    3. Random random = new Random  and random.Next

  */

    internal class L5Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ///*
            // if conditional sentence
            // */
            //string s = Console.ReadLine();
            //bool b = s == "hi";
            //if (b)  // not need the ; to end
            //{   // in the C# the Bool compution is special in !, this is not in pyhthon logical operation
            //     && = and ||= or
            //    Console.WriteLine("Hello");
            //}
            //Console.WriteLine("over");
            Console.WriteLine("player ---- 0 ~100, 4 scale");
            Console.Write("please input the number");
            string sc = Console.ReadLine();
            int sc1 = Convert.ToInt32(sc);
            if (sc1 > 100 || sc1 < 0)
            {
                Console.WriteLine("your input is not effective");
            }
            else if (90 <= sc1)
            {
                Console.WriteLine("scale A");
            }
            else if (sc1 >= 80)  // python i
            {
                Console.WriteLine("Scale B");
            }
            else if (60 <= sc1)
            {
                Console.WriteLine("Scale C");
            }
            else
            {
                Console.WriteLine("Scale D");
            }


            Random random = new Random();  // alway only
            int rand = random.Next(0, 1000000);  // limitless
            int shit = random.Next(0, 1);
            Console.Write("input the number");           
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            Console.WriteLine("over");
            if (num>=1000000 || num<0)
            {
                Console.WriteLine($" random is {rand}, your input is not effective");
            }
            else if (num < rand)
            {
                Console.WriteLine($" random is: "+rand  +     "fail");  // however you change the space the string is attach the number
            }
            else if (num > rand)  // python i
            {
                Console.WriteLine(" random is {0}, win", (rand));
            }
            else
            {
                Console.WriteLine($" random is {rand}, equal");
            }
            
            Console.WriteLine("over");
        }
    }
}


