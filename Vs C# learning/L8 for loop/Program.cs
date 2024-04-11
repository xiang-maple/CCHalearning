namespace L8_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //for (int i = 0; i<100; i++)
            //{
            //    Console.WriteLine(i+1);
            //}
            ////int a = i + 1;  // error 
            //int j = 0;

            //while (j < 100)
            //{
            //    j++;
            //    Console.WriteLine(j);
            //}
            long j = 1;  
            for (int i = 1; i<50; i++)
            {
                j = j * i;
            }
            Console.WriteLine(j);
            for (int i = 0; i < 100; i++)
            {
                i++;
                if (i % 13 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            for(int k = 1; k <= 5; k++)
            {

                for (int i = 1; i <= 5; i++)
                {
                    Console.Write($"{k}-{i}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("please input a number, and then calculate the sum and mutiplication from 1 to this number");
            Console.WriteLine("please input the number: ");
            string input = Console.ReadLine();
            long num = Int64.Parse(input);
            long sum = 0;
            long mup = 1;
            for(long num1 = 0; num1 < num; num1++)
            {
                sum = sum + num1+1;
                mup = mup * (num1+1);
            }
            Console.WriteLine($"1`{num} sum is: {sum}");

            Console.WriteLine($"1~{num} mup is: {mup}");
            for (int i = 0; i < 1000; i++)
            {
                if ((i+1)%7==0)
                {
                    Console.WriteLine($"7 beishu is {i} ");
                    continue;
                }
                else if ((i + 1) % 11 == 0)
                {
                    Console.WriteLine($"11 beishu is {i} ");
                    
                }
                else if ((i + 1) % 13 == 0)
                {
                    Console.WriteLine($"13 beishu is {i} ");
                    
                }
                
            }
            int hh = 1;
            for (int k = 1; k <= 9; k++)
            {
                for (int o = 1; o <= 9; o++)
                {
                    
                    if (k>=hh && o>=hh)
                    Console.Write($"{k}*{o}={o * k}\t");
                }
                hh = hh +1;
                Console.WriteLine();
            }
        }

    }
}
