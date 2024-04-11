

/*
pay attention to the beginning set for every program
 */
namespace L4_type_transform_and_string_format_change
{
    internal class L4Program
    {
        static void Main(string[] args)
        {
            float height = 0.55f;
            height += 1;  // we use float to change int is ok, because float is broad than int.
            Console.WriteLine(height);
            float o = 3.0f;
            Console.WriteLine(o);
            float f = 3;  // 3 - 3.0
            Console.WriteLine(f);
            f += 0.12f;
            Console.WriteLine(f);
            int it = 1;
            //it += f;  // so this way is wrong, 1.2 can not behave in int form, but 1 can behave in float form 1.0
            it += (int)f;
            Console.WriteLine(it);
            int a = 4;
            Console.WriteLine(a / 3);
            float b = a / 3;
            Console.WriteLine(b);
            float c = a * 1.0f / 3;
            Console.WriteLine(c);


            //if you want to transform it you should use the compulsory way
            int it1 = 4;
            Console.WriteLine(it1 / 3);
            float f1 = it1 / 3;
            Console.WriteLine(f1);
            float f2 = (float)it1 / 3;  // this is compulsory transform
            Console.WriteLine(f2);
            int m = (int)f1;
            a = (int)f1;
            //n = (int)f1;  // we know not ytpe variables cannot directly assign
            Console.WriteLine(m);

            //input a number , print its answer divide 2
            Console.WriteLine("please input a number, this number will be divide  two");
            string input = Console.ReadLine();  // this we input kongge it will be not effective, becasue it is not a number
            Console.WriteLine(1 + input + 2);
            int n = Convert.ToInt32(input); // first way transform str into int
            // int n = int.Parse(input);  // second way transform str into int
            Console.WriteLine("its answer is: " + (float)n / 2);

            string ss = "hello";
            int ab = 1;
            ss = ss + ab * 2 + 3;
            Console.WriteLine(ss);

            //format str
            Console.WriteLine("me age is: " + ab);  // first way plus connect

            Console.WriteLine("{0} eat {1} hate {2}", "maple", "me", "shit");  // second way order (index show)
            string kk = "hello";
            float score = 8.5f;
            Console.WriteLine($"the game {kk} is {score}"); // third way of transform ($ form)
            string name = "xiang";
            string mm = "maple";
            Console.WriteLine($"{name} like {mm}");

            Console.WriteLine("{0} like {1}", name, m);
            // there are two forms about how to use the variables to assign in other string varibal
            string game = "old game";
            float sc = 9.5f;
            Console.WriteLine($"game {game} mark is {sc}");
            //string info = "{0} like {1}", name, mm;
            string info = string.Format("{0} like {1}", name, mm);
            Console.WriteLine(info);
            string gameinfo = $"game {game} mark is {sc}";
            Console.WriteLine(gameinfo);
            //translation sign(\n,,,\t,,,)
            Console.WriteLine($"game \n{game} mark \nis \n{sc}y");
            Console.WriteLine($"game \t{game} \"mark\" \tis \t{sc}\\y");
        }
    }
}
