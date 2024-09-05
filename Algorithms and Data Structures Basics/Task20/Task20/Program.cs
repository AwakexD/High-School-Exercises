namespace Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(s => int.Parse(s)).ToList();
            int number = int.Parse(Console.ReadLine());

            if (list.Contains(number))
            {
                Console.WriteLine($"{number} Exists in the List");
            }
            else
            {
                Console.WriteLine($"{number} Not exists in the List");
            }
            
        }
    }
}