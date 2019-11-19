using System;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uitleg
            Console.WriteLine("Welkom bij de auto dealer!");
            Console.WriteLine();
            Console.WriteLine("De standaard prijs van een auto is 25.000 euro");
            Console.WriteLine("Je kunt speciale upgrades op je auto krijgen!");
            Console.WriteLine("Zoals Metallic lak (5% verhoging)");
            Console.WriteLine("Een Leren bekleding (5% verhoging)");
            Console.WriteLine("En een Automaat (1.000 euro verhoging)");
            Console.WriteLine("-+-+-+-+-+-");
            Console.WriteLine("Op het totaalbedrag komt nog 21% BTW");
            Console.WriteLine();

            //Vragen
            Console.WriteLine("Wat is je volledige naam?");
            string Naam = Console.ReadLine();
            Console.WriteLine("Wil je een metallic lak erop?");
            string Lak = Console.ReadLine();
            Console.WriteLine("Wil je een Leren bekleding?");
            string Bekleding = Console.ReadLine();
            Console.WriteLine("Wil je een Automaat?");
            string Automaat = Console.ReadLine();

            //Geld
            int Geld = 25000;

            //IF
            if (Lak == "ja"){
                Geld = (Geld / 100 * 5) + Geld;
            }
            if (Bekleding == "ja"){
                Geld = (Geld / 100 * 5) + Geld;
            }
            if (Automaat == "ja"){
                Geld += 1000;
            }

            //Rekening
            Console.WriteLine();
            Console.WriteLine("Rekening");
            Console.WriteLine("-+-+-+-+-+-");
            Console.WriteLine("Naam : " + Naam);
            if (Lak == "ja"){
                Console.WriteLine("Kosten Metallic Lak : 1.250 euro");
            }
            if (Bekleding == "ja"){
                Console.WriteLine("Kosten Leren Bekleding : 1.250 euro");
            }
            if (Automaat == "ja"){
                Console.WriteLine("Kosten Automaat : 1.000 euro");
            }
            Console.WriteLine();
            Console.WriteLine("Totaal zonder BTW : " + Geld + " euro");
            //BTW
            Geld = Geld / 100 * 21 + Geld;
            Console.WriteLine("Totaal met BTW : " + Geld + " euro");
        }
    }
}