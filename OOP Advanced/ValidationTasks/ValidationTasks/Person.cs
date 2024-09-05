using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationTasks
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string fname, string lname, int age, double salary)
        {
            FirstName  = fname;
            lastName = lname;
            Age = age;
            Salary = salary;
        }

        public string FirstName 
        { 
            get { return firstName; }
            set 
            {
                if(string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("Invalid Name!");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("Invalid Name!");
                }
                lastName = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Age!");
                }
                this.age = value;
            }
        }

        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 460 || value > 2000)
                {
                    throw new ArgumentException("Invalid Salary!");
                }
                this.salary = value;
            }
        }

        public void IncreaseSalary(double percent)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * percent / 100;

            }
            else
            {
                this.salary += this.salary * percent / 100 / 2;
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} is {this.age} years old. His salary is {this.salary}";
        }
    }
}
