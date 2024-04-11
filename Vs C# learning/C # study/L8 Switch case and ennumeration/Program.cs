namespace L8_Switch_case_and_ennumeration
{
    internal class Program
    {
        enum season
        {
            spring,
            summer,
            autumn,
            winter,
        }

        static void Main(string[] args)
        {
            // test the enum
            season tt = season.spring;
            Console.WriteLine(tt);
            int ttn = Convert.ToInt32(tt);
            Console.WriteLine(ttn);
            Console.WriteLine("season from 0 to 3 is the normal season order");
            
            
            // ennumeration 
            while (true)
            { 
                Console.WriteLine("input your number");
                string inpput = Console.ReadLine();
                
                int ssn = int.Parse(inpput);
                season season = (season)ssn;
                switch (season)
                {
                    case season.spring:
                        Console.WriteLine("the season you choose is " + season);
                        break;
                    case season.summer:
                        Console.WriteLine("the season you choose is " + season);
                        break;
                    case season.autumn:
                        Console.WriteLine("the season you choose is " + season);
                        break;
                    case season.winter:
                        Console.WriteLine("the season you choose is " + season);
                        break;
                    
                    default:
                        Console.WriteLine("your input is no effective, choice over");
                        return;

                }
            }

            //
        }
            
        
    }
}
