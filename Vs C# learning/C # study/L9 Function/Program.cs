using System.Reflection.Metadata.Ecma335;

namespace L9_Function
{
    internal class Program
    {
        //static int inpunum()
        //{
        //    string input = Console.ReadLine();
        //    int num = Convert.ToInt32(input);
        //    return num;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("please input your first number");
        //    int a = inpunum();
        //    Console.WriteLine("please input your second number");
        //    int b = inpunum();
        //    Console.WriteLine("please input your third number");
        //    int c = inpunum();

        //    Console.WriteLine($"the sum of three number is {a + b + c}");
        //}
        ///*
        // use function to simplify the while loop 
        // */
        //static void Main(string[] arge)
        //{

        //}

        // the review of function 
        
        static int numinput()
        {
            string input = Console.ReadLine();
            int a = Convert.ToInt32(input);
            //int a = int.Parse(input);  // second way
            return a;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("input your first number");
            int a = numinput();
            Console.WriteLine("input your second number");
            int b = numinput();
            Console.WriteLine("input your second number");
            int c = numinput();
            int sum = a + b + c;
            Console.WriteLine($"the sum of three number is {sum}");
        }
    }
}
