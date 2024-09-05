using System;

namespace Task12_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> arrlist = new ArrayList<int>(5);

            arrlist.Add(5);
            arrlist[0] = arrlist[0] + 1;
            int element = arrlist.RemoveAt(0);


            Console.WriteLine(element);
        }
    }
}
