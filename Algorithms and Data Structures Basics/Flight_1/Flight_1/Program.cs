using System;

namespace Flight_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int izlitaneChas = int.Parse(Console.ReadLine());
            int izlitaneMinuti = int.Parse(Console.ReadLine());
            int produljitelnost = int.Parse(Console.ReadLine());

            DateTime departureTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, izlitaneChas, izlitaneMinuti, 0);
            DateTime arrivalTime = departureTime.AddMinutes(produljitelnost);

            Console.WriteLine("kacane vuv: " + arrivalTime.ToString("HH:mm"));
        }
    }
}
