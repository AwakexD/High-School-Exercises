using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    public struct CirculatQueue<T>
    {
        private T[] elements;
        private int startIndex = 0;
        private int endIndex = 0;

        private const int DefaultCapacity = 4;
        public int Count { get; private set; }

        public CirculatQueue() : this(16) { }
        
        public CirculatQueue(int capacity)
        {
            elements = new T[capacity];
        }

        public void Enqueue(T item) 
        {
            if (this.Count >= this.elements.Length)
            {
                this.Grow();
            }

            this.elements[endIndex] = item;
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;
        }

        private void Grow()
        {
            var newElements = new T[2 * this.elements.Length];
            this.CopyAllElementsTo(newElements);
            this.startIndex = 0;
            this.endIndex = this.Count; 
        }

        private void CopyAllElementsTo(T[] resultArr)
        {
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;

            for (int i = 0; i < Count; i++)
            {
                resultArr[destinationIndex] = elements[sourceIndex++];
                sourceIndex = (sourceIndex + 1) % (this.elements.Length);
                destinationIndex++;
            }
        }

        public T Dequeue() 
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            var result = this.elements[startIndex];
            this.startIndex = (this.startIndex  +1 ) % this.elements.Length;
            this.Count--;
            return result;
        }

        public T[] ToArray() 
        { 
            var result = new T[Count];
            CopyAllElementsTo(result);
            return result;
        }
    }
}
