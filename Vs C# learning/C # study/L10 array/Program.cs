using System.Reflection.Metadata.Ecma335;

namespace L10_array
{
    internal class Program
    {   
        // to find the index of the number in array, if not find return -1
        static int FindElement(int[] array, int n)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==n)
                {
                    return i;
                }
            }
            return -1;

        }
        // to find whethe the number is in the array ot not
        static bool Haselement(int[] ary, int n)
        {
            for (int i = 0; i < ary.Length; i++)
            {
                if (ary[i] == n)
                {
                    return true;
                }
            }
            return false;

        }

        // find the max of the function
        static int Maxelement(int[] array)
        {
            int Max = array[0];
            // get all nubmer of array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>Max)
                {
                    Max = array[1];
                }
            }
            return Max;
        }




        static void Main(string[] args)
        {
            // create array
            //int[10] array;  // error
            // create a case array 
            int[] array = new int[5];  // the type array --int[] and its value return
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            // initialized array
            int[] ar = new int[] { -1, -2, -3, -4, -5 };
            // string array
            string[] ary = new string[] {"1","a","dfas","fdsaf" };

            // find the element of index
            Console.WriteLine(array[1]);
            Console.WriteLine(ary[3]);
            Console.WriteLine(ar[2]);
            // find all elements of the array
            for (int i =0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int i =0; i<ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }
            int re = FindElement(array, 4);
            Console.WriteLine(re);
            bool tf = Haselement(ar, -1);
            Console.WriteLine(tf);
            int max = Maxelement(ar);
            Console.WriteLine(max);

        }
    }
}
 