namespace L7_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // print block
            //for (int j = 0; j<4; j++  )
            // {
            //     for(int i = 0; i<5; i++)
            //     {
            //         Console.Write($"{j+1}-{i+1},");

            //     }
            //     Console.WriteLine();
            // }

            // print the plus from 1 to 100 and multip from 1 to 100
            double m = 1;
            int l = 0;
            for (int k = 0; k <100; k++)
            {
                l += k+1;
                m *= (k + 1);
            }
            Console.WriteLine(l);
            Console.WriteLine(m);
        }
    }
}
