using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinues = int.Parse(Console.ReadLine());
            int enterHour = int.Parse(Console.ReadLine());
            int enterMinutes = int.Parse(Console.ReadLine());

            DateTime examTime = new DateTime(2023, 1 ,1, examHour, examMinues, 0);
            DateTime enterTime = new DateTime(2023, 1, 1, enterHour, enterMinutes, 0);
            TimeSpan span = enterTime - examTime;


            if (span.TotalMinutes > 0) //proverka late
            {
                Console.Write("Late"); 
                if (span.TotalMinutes < 60)
                {
                    Console.WriteLine($", {span.TotalMinutes} minutes after the start");
                }
                else
                {
                    Console.WriteLine($", {span.Hours}:{span.Minutes:00} hours after the start");
                }
            }
            else if (span.TotalMinutes >= -30) //proverka ontime
            { 
                Console.WriteLine("On time");
                if (span.TotalMinutes != 0)
                {
                    Console.WriteLine($"{-span.TotalMinutes} minutes before the start");
                }
            }
            else 
            {
                Console.Write("Early"); // early proverka
                if (span.TotalMinutes > -60)
                {
                    Console.WriteLine($", {Math.Abs(span.TotalMinutes)} minutes before the start");
                }
                else
                {
                    Console.WriteLine($", {Math.Abs(span.Hours)}:{Math.Abs(span.Minutes):00} hours before the start");
                }
            }
        }
    }
}
