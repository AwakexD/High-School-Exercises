using System;

namespace Task4
{
	public class Program
	{
		static void Main(string[] args)
		{
			decimal budget = decimal.Parse(Console.ReadLine());
			string category = Console.ReadLine().ToLower(); //VIP Normal
			int peopleCount = int.Parse(Console.ReadLine());

			decimal transportCost = SetTransportCost(peopleCount, budget);
			decimal ticketCost = 0;

			if (category == "vip")
			{
				ticketCost = 499.99m * peopleCount;
			}
			else if (category == "normal")
			{
				ticketCost = 249.99m * peopleCount;
			}

			decimal totalCost = ticketCost + transportCost;

			if (budget >= transportCost)
			{
				Console.WriteLine($"Yes! You have {budget - totalCost:f2} leva left.");
			}
			else
			{
				Console.WriteLine($"Not enough money! You need {totalCost - budget:f2} leva.");
			}
		}

		static decimal SetTransportCost(int peopleCount, decimal budget)
		{
			if (peopleCount >= 1 && peopleCount <= 4)
			{
				return budget * 0.75m;
			}
			else if (peopleCount > 4 && peopleCount < 10)
			{
				return budget * 0.6m;
			}
			else if (peopleCount >= 10 && peopleCount < 25)
			{
				return budget * 0.5m;
			}
			else if (peopleCount >= 25 && peopleCount < 50)
			{
				return budget * 0.4m;
			}
			else
			{
				return budget * 0.25m;
			}

		}
	}
}
