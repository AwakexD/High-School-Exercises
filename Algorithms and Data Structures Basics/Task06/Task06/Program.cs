using System;

namespace Task06
{
	public class Program
	{
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int ngd = FindGcd(number1, number2); //nai golqm delitel
            int nmd = number1 * number2 / ngd; // nai maluk delitel

			Console.WriteLine($"Nai golqm delitel {ngd}");
			Console.WriteLine($"Nai maluk delitel {nmd}");
        }

        static int FindGcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
