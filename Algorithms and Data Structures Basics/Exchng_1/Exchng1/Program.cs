using System;
using System.Linq;

namespace Exchng1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arr = number.ToString().Select(x => int.Parse(x.ToString())).ToArray();
            
            Array.Reverse(arr);

            Console.WriteLine(String.Join("", arr));

        }
    }
}
