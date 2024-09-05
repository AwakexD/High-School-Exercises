using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_1
{
    public class School
    {
        private string name;
        private string city;
        List<Klass> paralelki;

        public School(string n, string c)
        {
            this.Name = n;
            this.City = c;
            paralelki = new List<Klass>();
        }

        public string Name
        {
            get { return this.name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Value cannot be null or empty");
                }   
                this.name = value;
            }
        }

        public string City
        {
            get { return this.city; }
            set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid city!");
                }

                this.city = value;
            }
        }

        public void AddKlass(Klass klass)
        {
            this.paralelki.Add(klass);
        }

        public int GetStudentsCount() => paralelki.Sum(x => x.Count);

        public override string ToString()
        {
            return $"{this.Name} from {this.City} - count of students {GetStudentsCount().ToString()}";
        }
    }
}
