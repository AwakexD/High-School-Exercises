namespace Task26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            array = array.OrderByDescending(x => x).ToArray();

            Console.WriteLine($"{array[indexes[0] - 1]} {array[indexes[1] - 1]}");
        }
    }
}