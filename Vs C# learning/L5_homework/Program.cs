namespace L5_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 1;
            float b = 1.43f;
            float c = (float)a / 3;
            Console.WriteLine(c);
            Console.WriteLine("input the number");
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            int m =int.Parse(s);
            Console.WriteLine(n);
            Console.WriteLine(m);
            Console.WriteLine("n \n= "+n+", mnbnbnb \t=  "+m);
            // homework
            Console.WriteLine("input your name");
            string name = Console.ReadLine();
            Console.WriteLine("input your age");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);
            Console.WriteLine("input your weight, unit is kg");
            string  input1 = Console.ReadLine();
            int weight = int.Parse(input1);
            Console.WriteLine($"{name} is {age} years old, weight {weight}kg");
            Console.WriteLine("input 3 number from n1 n2 to n3 in order, then we will gain its average" );
            string in1 = Console.ReadLine();
            string in2 = Console.ReadLine();
            string in3 = Console.ReadLine();
            int n1 = Convert.ToInt32(in1); 
            int n2 = Convert.ToInt32(in2); 
            int n3 = Convert.ToInt32(in3);
            Console.WriteLine("their average is " +(float) (n1+n2+n3)/3);
            

        }
    }
}