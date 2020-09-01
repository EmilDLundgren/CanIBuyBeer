/*
 * om ålder > 17 OCH location == "Krogen" OCH om leg == "J" OCH om promille < 1.0 JA
 * om ålder > 19 OCH location == "Systemet" OCH om leg == "J" JA OCH om promille < 1.0 JA
*/

using System;

namespace CanIBuyBeer
{
    class Program
    {
        static bool CanIBuyBeer(int age, string location, decimal promille, string legg)
        {
            bool canIBuyBeer = false;
            if(legg == "J" && promille < 1.0m)
            {

                if (location == "skola" && age > 15)
                {
                    canIBuyBeer = true;
                }

                if (location == "krogen" && age > 17)
                {
                    canIBuyBeer = true;
                }

                if (location == "systemet" && age > 19)
                {
                    canIBuyBeer = true;
                }

            }
            return canIBuyBeer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Superdupermegaauber 1.01");

            Console.Write("Hur gammal är du? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Location: ");
            string location = Console.ReadLine().ToLower();
            Console.Write("Har du legg med dig? (J/N)");
            string legg = Console.ReadLine().ToUpper();
            Console.Write("Vilken promillehalt:");
            decimal promille = Convert.ToInt32(Console.ReadLine());

            bool canIBuyBeer = CanIBuyBeer(age, location, promille, legg);

            if (canIBuyBeer)
                Console.WriteLine("Du får köpa");
            else
                Console.WriteLine("du får inte köpa");
                


            /*
            if(age > 17 && location == "krogen" && legg == "J" && promille < 1.0m)
                Console.WriteLine("Du får köpa!");
            if (age > 19 && location == "systemet" && legg == "J" && promille < 1.0m)
                Console.WriteLine("Du får köpa!");
            else
                Console.WriteLine("Gå hem");
            */
        }
    }
}
