using Microsoft.VisualBasic;
using Microsoft.Win32.SafeHandles;

namespace School_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<School> schools = new List<School>();

            while (true)
            {
                string input = Console.ReadLine();  
                if (input.ToLower() == "finish")
                {
                    break;
                }

                string[] schoolData = input.Split("; ");
                string[] classesData = Console.ReadLine().Split("; ");

                schools.Add(new School(schoolData[0], schoolData[1]));

               foreach (string css in classesData) 
                {
                    string[] info = css.Split("-");
                    schools.Last().AddKlass(new Klass(info[0], int.Parse(info[1])));
                    
                }
    
            }
            foreach (School sch in schools.OrderBy(s => s.Name).ThenBy(x => x.City).ThenBy(c => c.GetStudentsCount()))
            {
                Console.WriteLine(sch);
            }
        }
    }
}