using System;

namespace Task7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			int counter = 0;
			int divisior = 5;

			while (number / divisior > 0) //10 / 5 = 2 | 10 / 25 = 0.4 < 0  
			{
				counter = number / divisior; // counter = (10 / 5) = 2
				divisior = divisior * 5; // 5 * 5 = 25
			}

			Console.WriteLine($"{number}! = has {counter} zeros");
		}
	}
}
