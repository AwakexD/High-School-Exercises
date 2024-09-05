namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomArrayList arrayList = new CustomArrayList();
            arrayList.Add(1);
            arrayList.Add("String");
            arrayList.Add(true);

            Console.WriteLine(arrayList.Count);
            arrayList.Remove(1);
        }
    }
}