using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_1
{
    public class Klass
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public Klass(string name , int count )
        {
           this.Name = name;

           this.Count = count;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Count}";
        }
    }
}
