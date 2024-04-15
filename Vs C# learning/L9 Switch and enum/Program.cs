using System.Security.Cryptography.X509Certificates;

namespace L9_Switch_and_enum
{
    internal class Program
    {
        // review of all
        //    //static void Main(string[] args)
        //{
        //   // switch
        //    // if you input a is attack b is defend c is run away
        //    string s = Console.ReadLine();
        //    switch (s)
        //    {
        //        case "a":
        //            Console.WriteLine("attack");
        //            break;
        //        case "b":
        //            Console.WriteLine("defend");
        //            break;

        //        default:
        //            Console.WriteLine("run away");
        //            break;
        //    }

        //    // the difference between the switch and if , is case is quick then if because with seeking from first to the goal
        //    string m = Console.ReadLine();
        //    if (s == "a")
        //    {
        //        Console.WriteLine("attack");
        //    } 
        //    else if (s == "b")
        //    {
        //        Console.WriteLine("defend");
        //    }
        //    else
        //    {
        //        Console.WriteLine("run away");
        //    }

        //}

        // enum set
        //        enum gesture
        //{
        //    rock,
        //    scissors,
        //    paper,
        //}
        //// how to use it
        //static void Main(string[] args)
        //{
        //    gesture hand = gesture.rock;
        //    Console.WriteLine(hand);
        //    Console.WriteLine((int)hand);


        //}

        // first homework enum four fruit
        enum fruit
        {
            apple = 1,
            banana =2,
            orange=3,
            grape =4,
        }

        static void Main(string[] args)
        {
            // tell user the 1~4 is respond to four fruit
            Console.WriteLine("1~4 is respond to four fruit");
            Console.WriteLine("plaese input your number");
            string input = Console.ReadLine();
            int ipt = int.Parse(input);
            fruit ff = (fruit)ipt;
            Console.WriteLine("the fruit you choose is " + ff);
            // define the price of the fruit
            int price = 0;
            switch (ipt)
            {
                case (1):
                   price = 4;
                   Console.WriteLine("the price is " + price);
                    break;
                case (2):
                   price = 5;
                   Console.WriteLine("the price is " + price);
                    break;
                case (3):
                    price = 5;
                    Console.WriteLine("the price is " + price);
                    break;
                case (4):
                   price = 20;
                   Console.WriteLine("the price is " + price);
                    break;
            }

            
            // tell use input how much he will buy
            Console.WriteLine("the number your buy");
            string inpput = Console.ReadLine();
            int iit = Convert.ToInt32(inpput);

            // final print
            Console.WriteLine($"your buy {iit} jing {ff}, the tota price is {price*iit}");
        }
    }


}
