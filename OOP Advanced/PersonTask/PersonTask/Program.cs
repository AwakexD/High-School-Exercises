namespace PersonTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameInput = Console.ReadLine();
            int ageInput = int.Parse(Console.ReadLine());

            if (ageInput <= 15)
            {
                Children child = new Children(nameInput, ageInput);
                child.PrintToConsole();
            }
            else
            {
                Person person = new Person(nameInput, ageInput);
                person.PrintToConsole();
            }
        }
    }
}