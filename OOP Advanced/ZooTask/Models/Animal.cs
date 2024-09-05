using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTask.Models
{
    public class Animal
    {
        public virtual string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }
    }
}
