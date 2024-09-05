namespace Task28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            BubbleSort.Sort(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}