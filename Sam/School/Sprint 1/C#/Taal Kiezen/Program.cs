using System;

namespace Taal_Kiezen
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean Start = true;
                while (Start == true){
                Console.WriteLine("Kies je taal - Wähle deine Sprache - Choose your language");
                Console.WriteLine("1 = Nederlands");
                Console.WriteLine("2 = Duits");
                Console.WriteLine("3 = Engels");
                Console.WriteLine("4 = Frans");
                Console.WriteLine("5 = Spaans");
                Console.WriteLine("6 = Hawaïaans");
                string Taal = Console.ReadLine();
                if (Taal == "1"){
                    Console.WriteLine("De huidige maand is oktober.");
                }
                else if (Taal == "2"){
                    Console.WriteLine("Der aktuelle Monat ist Oktober.");
                }
                else if (Taal == "3"){
                    Console.WriteLine("The current month is October.");
                }
                else if (Taal == "4"){
                    Console.WriteLine("Le mois en cours est Octobre.");
                }
                else if (Taal == "5"){
                    Console.WriteLine("El mes actual es Octubre.");
                }
                else if (Taal == "6"){
                    Console.WriteLine("ʻO kēia ka mahina o kēia lā ʻo ʻOkakopa");
                }
                else {
                    Console.WriteLine("Die taal ken ik niet!");
                }
                string Check;
                Console.WriteLine("Wil je nog een keer?");
                Check = Console.ReadLine();
                if (Check == "ja"){
                    Console.WriteLine("Oke");
                }
                else {
                    Start = false;
                }
            }
        }
    }
}
