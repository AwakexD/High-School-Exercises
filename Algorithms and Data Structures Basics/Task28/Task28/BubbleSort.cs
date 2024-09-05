using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task28
{
    public class BubbleSort
    {
        public static void Sort<T>(T[] a) where T : IComparable<T>
        {
            int n = a.Length;
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < n - 1; i++)
                {
                    if (Less(a[i + 1], a[i]))
                    {
                        Swap(a, i, i + 1);
                        swapped = true;
                    }
                }

                n--;
            } while (swapped);
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
        }
    }
}
