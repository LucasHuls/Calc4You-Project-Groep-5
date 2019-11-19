//Sam Elfring
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ondernemend_gedrag_opdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string check = "ja";
            while (check == "ja")
            {
                Console.WriteLine("Voer Getal 1 in: ");
                int getal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Voer Getal 2 in: ");
                int getal2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Voer Getal 3 in: ");
                int getal3 = Convert.ToInt32(Console.ReadLine());

                if ((getal1 > getal3) && (getal2 > getal3))
                {
                    Console.WriteLine("Getal 3 is het kleinste getal.");
                }
                else
                {
                    Console.WriteLine("Getal 3 is niet het kleinste getal.");
                }
                Console.WriteLine("Wil je nog een keer? (ja of nee)");
                check = Console.ReadLine();
            }
        }
    }
}
