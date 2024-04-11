namespace L6_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string input = Console.ReadLine();
            float num = Convert.ToInt32(input);
            
            if (num%2 == 0||num%5 == 0||num%3 == 0)
            {
                Console.WriteLine(0);
            }
            else 
            {
                Console.WriteLine(num);
            }
            string input1 = Console.ReadLine();
            float num1 = Convert.ToInt32(input1);
            if (num1 % 2 == 0) 
            {
                Console.WriteLine(num1*2);
            }
            if (num1 % 3 == 0)
            {
                Console.WriteLine(num1 * 3);
            }
            if (num1 % 5 == 0)
            {
                Console.WriteLine(num1 * 5);
            }
            if(num1 %2!=0 && num1%3!=0 && num1!=0)
            {
                Console.WriteLine(0);
            }
        }

    }
}
