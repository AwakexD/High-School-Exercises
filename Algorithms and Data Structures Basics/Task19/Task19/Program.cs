namespace Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1, tempcount = 1;
            int startIndex = 0, endIndex = 0;


            int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            List<int> list = new List<int>();

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    tempcount++;
                    if (tempcount > count)
                    {
                        count = tempcount;
                        startIndex = i + 2 - count;
                        endIndex = i + 1;
                    }
                }
                else
                {
                    tempcount = 1;
                }
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                list.Add(array[i]);
            }

            Console.WriteLine(string.Join(",", list));

        }
    }
}