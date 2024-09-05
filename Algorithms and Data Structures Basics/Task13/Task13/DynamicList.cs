using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    public class DynamicList
    {
        private class Node
        {
            private object element;
            private Node next;

            public object Element
            {
                get { return element; }
                set { element = value; }
            }

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            public Node(object element, Node prevNode)
            {
            }

            public Node(object element)
            {
            }
        }

        private Node head;
        private Node tail;
        private int count;
        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
        public void Add(object item)
        {
            throw new NotImplementedException();
        }
        public object Remove(int index)
        {
            throw new NotImplementedException();
        }

        public int Remove(object item)
        {
            throw new NotImplementedException();
        }
        public int IndexOf(object item)
        {
            throw new NotImplementedException();
        }
        public bool Contains(object item)
        {
            throw new NotImplementedException();
        }
        public object this[int index] { get { return index; } }
        
        public int Count
        {
            get
            {
                return count;
            }
        }
    }
}
