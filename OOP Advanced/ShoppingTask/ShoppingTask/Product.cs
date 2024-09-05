using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingTask
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

    }
}
