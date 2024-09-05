using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class Shoes
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Shoes(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
