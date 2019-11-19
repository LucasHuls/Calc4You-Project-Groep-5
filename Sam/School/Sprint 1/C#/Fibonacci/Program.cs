using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int som = 1;

            while (num1 <= 121393){
                som = num1 + num2;
                num1 = num2;
                num2 = som;
                Console.WriteLine(num2);
            }
        }
    }
}