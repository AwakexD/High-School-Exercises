namespace Task21
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine($"Sum of the elements in the list: {list.Sum():f2}");
            Console.WriteLine($"Avereage : {list.Average():f2}");
        }
    }
}