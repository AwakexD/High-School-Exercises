using System.Globalization;

namespace Task27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] day1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] day2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] combined = day1.Concat(day2).ToArray();

            Console.WriteLine(string.Join(" ", combined.OrderBy(x => x)));
        }
    }
}