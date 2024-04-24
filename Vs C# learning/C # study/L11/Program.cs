using System.Runtime.InteropServices;

namespace L11
{

    internal class Program
    {
        // create a case arraysd and place the message in the array case and make it all used 
        static bool[,] tickets = new bool[3, 4];
        static int i;
        static int j;
        static void plmesage()
        {

            // place the message
            for (int i = 0; i < tickets.GetLength(0); i++)
            {
                for (int j = 0; j < tickets.GetLength(1); j++)
                {
                    bool b = tickets[i, j];
                    if (!b)
                    {
                        Console.Write($"{i + 1}_{j + 1}have place   ");
                    }
                    else
                    {
                        Console.Write($"{i + 1}_{j + 1}not  place   ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void buyt()
        {

            // create buy way
            Console.WriteLine("please input the row number");
            i = numinput()-1;
            
            Console.WriteLine("please input the column number");
            j = numinput()-1;
            
            
            

        }

        static void placeshow()
        {
            // create whether there are prople or not

            bool b = tickets[i, j];
            if (!b)
            {
                Console.WriteLine($"you have bought the {i+1}_{j+1} ticket");
                tickets[i, j] = true;
            }
            else
            {
                Console.WriteLine($"the place {i+1}_{j+1} is not avialivable");
            }

        }


        static void Main(string[] args)
        {
            // show the place message
            plmesage();
            while (true)
            {
                // buy ticket
                buyt();

                // whether you buy it or not
                placeshow();

                Console.WriteLine("if you want to out of the bought menu, please inpput '010'. if you want check the place menu, please input 110 and then you will but ticket continuously");
                Console.WriteLine("if you input other number, you will buy again. if you don't input number the menu is over");
                int ot = numinput();
                if (ot == 010)
                {
                    break;
                }
                else if (ot == 110)
                {
                    plmesage();
                }
            }


        }
        static int numinput()
        {
            string input = Console.ReadLine();
            int a = Convert.ToInt32(input);
            //int a = int.Parse(input);  // second way
            return a;
        }
    }
}
