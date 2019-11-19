using System;

namespace Schrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int Jaar = 1900; Jaar < 2019; Jaar+=4){
                Console.WriteLine("{0} is een schrikkeljaar", Jaar);
            }
        }
    }
}