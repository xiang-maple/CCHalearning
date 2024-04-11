namespace L9_Function
{
    internal class Program
    {
        static int inpunum()
        {
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("please input your first number");
            int a = inpunum();
            Console.WriteLine("please input your second number");
            int b = inpunum();
            Console.WriteLine("please input your third number");
            int c = inpunum();

            Console.WriteLine($"the sum of three number is {a + b + c}");
        }
        /*
         use function to simplify the while loop 
         */
        //static void Main(string[] arge)
        //{
            
        //}
    }
}
