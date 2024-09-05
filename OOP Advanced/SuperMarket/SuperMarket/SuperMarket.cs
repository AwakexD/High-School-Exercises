using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class SuperMarket <T> 
    {
        private Dictionary<T, int> products = new Dictionary<T, int>();
        private Dictionary<T, double> prices = new Dictionary<T, double>();

        public void AddProduct(T product, double price, int quantity)
        {
            if (!products.ContainsKey(product))
            {
                products.Add(product, quantity);
                prices.Add(product, price);
            }
            else
            {
                products[product] += quantity;
            }
        }

        public void BuyProduct(T product, int quantity)
        {
            if (products.ContainsKey(product) && products[product] >= quantity)
            {
                products[product] -= quantity;
                Console.WriteLine("You successfully bought a product.");
            }
            else
            {
                Console.WriteLine("Not enough quantity!");
            }
        }

        public void PrintProducts()
        {
            int foodCount = 0;
            int shoesCount = 0;

            foreach (var product in products)
            {
                if (product.Key is Food)
                {
                    foodCount += product.Value;
                }
                else if (product.Key is Shoes)
                {
                    shoesCount += product.Value;
                }
            }

            Console.WriteLine($"There are {foodCount} foods and {shoesCount} shoes in the supermarket.");
        }
    }
}
