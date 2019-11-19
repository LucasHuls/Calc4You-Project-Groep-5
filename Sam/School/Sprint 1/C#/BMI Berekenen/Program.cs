using System;

namespace BMI_Berekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gewicht en Lengte vragen
            Console.WriteLine("Wat is jouw lengte (in cm)?");
            int Lengte = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wat is jouw gewicht (in kg)?");
            int Gewicht = Convert.ToInt32(Console.ReadLine());

            //BMI Uitrekenen
            double BMI = Gewicht / ( ( Lengte / 100.0 ) * ( Lengte / 100.0 ) );
            Console.WriteLine("Je BMI is {0:n2}",BMI );
        }
    }
}