namespace Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray(); ;
            SelectionSort selectionSort = new SelectionSort();

            SelectionSort.Sort(array);
            Console.WriteLine(string.Join(" ", array));
        }
    }
}