using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_ArrayList
{
    public class ArrayList<T>
    {
        private T[] items;
        private int count;
        private int capacity;

        public ArrayList(int initialCapacity)
        {
            items = new T[initialCapacity];
            count = 0;
            capacity = initialCapacity;
        }

        public int Count { get { return count; } }

        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity *= 2;
                Array.Resize(ref items, capacity);
            }

            items[count++] = item;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();

            T removedItem = items[index];

            for (int i = index; i < count - 1; i++)
                items[i] = items[i + 1];

            count--;

            return removedItem;
        }

        private void Shift(int index)
        {
            for (int i = 0; i < this.Count; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        private void Shrink()
        {
            T[] copy = new T[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }
    }
}
