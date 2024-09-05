using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    public class CustomArrayList
    {
        private object[] array;

        private int count;

        public int Count { get { return count; } }

        private static readonly int INITAL_CAPACITY = 4;

        public CustomArrayList()
        {
            array = new object [INITAL_CAPACITY];
            count = 0;
        }

        public void Add(object item)
        { 
            array = array.Concat(new object[] { item }).ToArray();
        }

        public void Insert(int index, object item)
        {
            array[index] = item;
        }

        public int IndexOf(object item)
        {
            return Array.IndexOf(array, item);
        }

        public void Clear()
        { 
            Array.Clear(this.array);
        }

        public bool Contains(object item) 
        {
            return array.Contains(item);
        }

        public object this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public object Remove(int index)
        {
            array = array.Where((v, i) => i != index).ToArray();
            return this[index];
        }

        public void Remove(object item)
        {
            int index = Array.IndexOf(array, item);
            array = array.Where((v, i) => i != index).ToArray();
        }
    }
}
