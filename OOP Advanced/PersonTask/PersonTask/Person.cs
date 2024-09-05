using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTask
{
    public class Person
    {
        private string  name;
        private int age;


        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid age!");
                }
            }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(string name, int age)
        {
            this.name  = name;
            this.age = age;
        }

        public virtual void PrintToConsole()
        {
            Console.WriteLine($"{this.Name}, {this.Age}");
        }
    }
}
