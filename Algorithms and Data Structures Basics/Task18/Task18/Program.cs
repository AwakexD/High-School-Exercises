namespace Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1, tempcount = 1, number = 0;
             

            int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                { 
                    tempcount++;
                }
                else
                {
                    tempcount = 1;
                }

                if (tempcount > count)
                {
                    count = tempcount;
                    number = array[i];
                }
            }

            for (int i = 0;i < count; i++)
            {
                Console.Write(number);
            }
        }
    }
}