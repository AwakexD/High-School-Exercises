using System;

namespace SuperMarket
{
    public class Program
    {
        static void Main(string[] args)
        {
            SuperMarket<object> superMarket = new SuperMarket<object>();

            string[] foodData = Console.ReadLine().Split(';');
            foreach (string food in foodData)
            {
                string[] foodInfo = food.Split('-');
                string name = foodInfo[0];
                double price = double.Parse(foodInfo[1]);
                int quantity = int.Parse(foodInfo[2]);

                superMarket.AddProduct(new Food(name, price), price, quantity);
            }

            string[] shoesData = Console.ReadLine().Split(' ');
            foreach (string shoes in shoesData)
            {
                string[] shoesInfo = shoes.Split('=');
                string name = shoesInfo[0];
                double price = double.Parse(shoesInfo[1]);
                int quantity = int.Parse(shoesInfo[2]);

                superMarket.AddProduct(new Shoes(name, price), price, quantity);
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] commandInfo = command.Split(' ');
                string type = commandInfo[0];
                string name = commandInfo[1];
                int quantity = int.Parse(commandInfo[2]);

                if (type == "Food")
                {
                    superMarket.BuyProduct(new Food(name, 0), quantity);
                }
                else if (type == "Shoes")
                {
                    superMarket.BuyProduct(new Shoes(name, 0), quantity);
                }

                command = Console.ReadLine();
            }

            superMarket.PrintProducts();
        }
    }
}
