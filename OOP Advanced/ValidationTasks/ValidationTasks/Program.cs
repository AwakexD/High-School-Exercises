using System.ComponentModel.DataAnnotations;

namespace ValidationTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            try
            {
                for (int i = 0; i < lines; i++)
                {
                    var input = Console.ReadLine().Split();
                    var person = new Person(input[0], input[1], int.Parse(input[2]), double.Parse(input[3]));
                    persons.Add(person);
                }

                Console.WriteLine("Before increase");
                PrintPersons(persons);

                double percent = double.Parse(Console.ReadLine());

                // Incraese Salary
                foreach (Person i in persons)
                {
                    i.IncreaseSalary(percent);
                }

                Console.WriteLine("After increase");
                PrintPersons(persons);
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }

        }

        static void PrintPersons(List<Person> persons)
        {
            foreach (Person person in persons.OrderByDescending(s => s.Salary))
            {
                Console.WriteLine(person);
            }
        }
    }
}