using System;

namespace Мuldig_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            //vzimane na purvoto i ptoroto chislo
            int first = number / 10;
            int second = number % 10;

            int product = first * second;

            Console.WriteLine(product);
        }
    }
}
