using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTask
{
    public class Player
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Player(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
    }
}
