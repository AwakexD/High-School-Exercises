using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    public class SelectionSort
    {
        public static void Sort<T>(T[] a) where T : IComparable<T>
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (Less(a[j], a[minIndex]))
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    Swap(a, i, minIndex);
                }
            }
        }

        static bool Less<T>(T first, T second) where T : IComparable<T>
        {
            return first.CompareTo(second) < 0;
        }

        static void Swap<T>(T[] collection, int from, int to)
        {
            T temp = collection[from];
            collection[from] = collection[to];
            collection[to] = temp;
            Console.WriteLine(string.Join(' ', collection));
        }
    }
}
