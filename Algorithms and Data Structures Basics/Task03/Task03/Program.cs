using System;

namespace Task03
{
	public class Program
	{
		static void Main(string[] args)
		{
			decimal budget = decimal.Parse(Console.ReadLine());
			string season = Console.ReadLine().ToLower();

			string holidayType = string.Empty;
			string destination = string.Empty;
			decimal moneySpent = 0;

			if (budget <= 100)
			{
				destination = "Somewhere in Bulgaria";
				if (season == "summer")
				{
					holidayType = "Camp";
					moneySpent = budget * 0.3m;
				}
				else
				{
					holidayType = "Hotel";
					moneySpent = budget * 0.7m;
				}
			}
			else if (budget <= 1000)
			{
				destination = "Somewhere in Balkans";
				if (season == "summer")
				{
					holidayType = "Camp";
					moneySpent = budget * 0.4m;
				}
				else
				{
					holidayType = "Hotel";
					moneySpent = budget * 0.8m;
				}
			}
			else
			{
				destination = "Somewhere in Europe";
				holidayType = "Hotel";
				moneySpent = budget * 0.9m;
			}

			//Output method
			Print(destination, holidayType, moneySpent);
		}

		static void Print(string destination, string holidayType, decimal moneySpent) => Console.WriteLine($"{destination}\n{holidayType} - {moneySpent:f2}");
	}
}
