  using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Security.Cryptography.X509Certificates;
/*
Some simple Short cut.
1. Ctrl shift+ L use to open the source controllor
2. shift + esc use to close the source controllor 
3. Ctrl alt + L use to delete the whole row  // for some reason these key is bad // I should use more mouse
 */
namespace L3__Variables_and_types
{
    internal class L3Program
    {
        static void Main(string[] args)
        {/*
          assignment, arithmatic, compound, assignment operator
            int variables
            */
            //Console.WriteLine("Hello, World!");
            //plus
            //int cat = 10;  // the usage of assignment operator
            //int dog = 20;
            //int tiger = cat + dog;
            //Console.WriteLine(cat + dog - tiger);

            //  // substract
            //  dog = dog - cat;
            //  Console.Write(dog - cat);
            //  Console.WriteLine("");
            //  Console.WriteLine("dog:" + dog);  // the usage of format print
            //  // multipe
            //  int mouse = dog * tiger;
            //  Console.WriteLine("mouse:" + mouse);

            //  // divide
            //  int giraffe = cat / dog;
            //  Console.WriteLine(giraffe);

            //  // % useage remainder divide
            //  Console.WriteLine("(tiger+cat+3)%dog =" + (cat + tiger + 3) % dog);

            //  int score = 90;
            //  score = score + 3;
            //  score -= 10;
            //  Console.WriteLine("score = " + score);
            //  int attack = 5;
            //  attack = attack + 1;
            //  attack += 1;
            //  attack *= 3;
            //  attack %= 2;
            //  Console.WriteLine("attack = " + attack);
            //  int fire = 100;
            //  fire++;  // automatically add 1 or sbbustract 1
            //  Console.WriteLine("++, fire = " + fire);
            //  fire--;  // if I want to add 2 or more I can't use theis form, should to use the way above.
            //  Console.WriteLine("--, fire = " + fire);

            //  // Conclusion (three ways of + 1)
            //  int b = 1;
            //  b = b + 1;
            //  b += 1;
            //  b++;

            //  // old way 
            //  ++b;
            //  --b;
            //  // score += attack++
            //  // score += ++attack
            //  attack++;
            //  score += attack;

            int n = 1;    // approximately -2.1 billion and 2.1 billion 
            /*
            Variables-float and double
               */
            float f = 1.122f;  // pay attention the usage of f  
            double g = 3.14;
            /*
             string 
             */
            string k = "Hello string!";
            /*
             bool (true or false)
             */
            bool m = true;

            string input = Console.ReadLine();
            Console.WriteLine("Hello" + input);
        }


    }
}
