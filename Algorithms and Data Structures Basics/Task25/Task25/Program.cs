namespace Task25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] StudentsScore = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ", StudentsScore.OrderByDescending(x => x).ToArray()));
        }
    }
}