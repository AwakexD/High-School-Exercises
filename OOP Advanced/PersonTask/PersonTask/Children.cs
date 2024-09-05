using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTask
{
    public class Children : Person
    {
        public Children(string name, int age) : base(name, age)
        {

        }

        public override void PrintToConsole()
        {
            Console.WriteLine($"{this.Name}, {this.Age} - child");
        }
    }
}
