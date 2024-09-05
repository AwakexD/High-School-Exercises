namespace Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> myStack = new Stack<int>(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(myStack.Pop() + " ");
            }
        } 
    }
}