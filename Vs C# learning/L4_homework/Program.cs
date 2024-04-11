namespace L4_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            float a = 1;
            Console.WriteLine("my number is : " + a);
            float b = 3.14324123f;
            a = b;
            Console.WriteLine(a);
            Console.WriteLine("please you name");
            string s = Console.ReadLine();
            Console.WriteLine("Welcome to C# world " + s);
            Console.WriteLine($"{s}, I believe you will become better day by day ");
            Console.WriteLine("{0} will marry maple", (s));
            string wp = $"{s}, I believe you will become better day by day ";
            Console.WriteLine(wp);
        }
    }
}
