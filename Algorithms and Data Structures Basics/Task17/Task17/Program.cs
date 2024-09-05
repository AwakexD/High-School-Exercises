namespace Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(Enumerable.SequenceEqual(arr1, arr2));
        }
    }
}