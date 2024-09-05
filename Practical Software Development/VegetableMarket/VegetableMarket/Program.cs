namespace VegetableMarket
{
    public class Program
    {
        static void Main(string[] args)
        {
            const decimal Euro = 1.94m;

            decimal vegetablePricePerKg = decimal.Parse(Console.ReadLine());
            decimal fruitsPricePerKg = decimal.Parse(Console.ReadLine());
            double vegetablesWeight = double.Parse(Console.ReadLine());
            double fruitsWeight = double.Parse(Console.ReadLine());

            decimal profit = CalculateProfit(vegetablePricePerKg, vegetablesWeight, fruitsPricePerKg, fruitsWeight) / Euro;

            Console.WriteLine(profit);
        }

        public static decimal CalculateProfit(decimal vegetablePricePerKg, double vegetablesWeight, decimal fruitsPricePerKg, double fruitsWeight)
        {
            return (vegetablePricePerKg * (decimal)vegetablesWeight) + (fruitsPricePerKg * (decimal)fruitsWeight);
        }
    }
}
