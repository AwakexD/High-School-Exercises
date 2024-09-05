using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingTask
{
    public class Person
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<string> Bag { get; set; }

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            Bag = new List<string>();
        }

        public void BuyProduct(Product product)
        {
            if (Money >= product.Cost)
            {
                Money -= product.Cost;
                Bag.Add(product.Name);
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }
    }
 }
