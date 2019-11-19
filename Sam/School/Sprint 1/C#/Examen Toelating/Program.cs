using System;

namespace Examen_Toelating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ben jij toegelaten tot het examen?");
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");

            //Wiskunde
            Console.WriteLine("Wat heb je gehaald voor Wiskunde?");
            double Wiskunde = Convert.ToDouble(Console.ReadLine());
            //Scheikunde
            Console.WriteLine("Wat heb je gehaald voor Scheikunde?");
            double Scheikunde = Convert.ToDouble(Console.ReadLine());
            //Natuurkunde
            Console.WriteLine("Wat heb je gehaald voor Natuurkunde?");
            double Natuurkunde = Convert.ToDouble(Console.ReadLine());
            //Biologie
            Console.WriteLine("Wat heb je gehaald voor Biologie?");
            double Biologie = Convert.ToDouble(Console.ReadLine());
            //Economie
            Console.WriteLine("Wat heb je gehaald voor Economie?");
            double Economie = Convert.ToDouble(Console.ReadLine());

            //Checken op scores
            double Totaal = Wiskunde + Scheikunde + Natuurkunde + Biologie + Economie;
            int Scores = 0;
            if (Totaal < 180){
                if (Wiskunde >= 60){
                    Scores++;
                }
                if (Scheikunde >= 60 || Natuurkunde >= 60){
                    Scores++;
                }
            }
            if (Totaal >= 180){
                Scores = 2;
            }
            if (Wiskunde < 40 || Scheikunde < 40 || Natuurkunde < 40 || Biologie < 40 || Economie < 40){
                Scores = 0;
            }

            
            if (Scores == 2){
                Console.WriteLine();
                Console.WriteLine("Je mag meedoen aan het examen!");
                Console.WriteLine("Je hebt namelijk een punten aantal van {0:n1}",Totaal);
            }
            else {
                Console.WriteLine();
                Console.WriteLine("Je mag niet meedoen aan het examen");
            }



        }
    }
}