using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    // Generic class
    public class Stack<T> : StackInterface<T>
    {
        private int _capacity;
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        private int _length;
        public int Length
        {
            get { return Index + 1; }
        }

        private T[] _elements;
        protected T[] Elements
        {
            get { return _elements; }
            set { _elements = value; }
        }

        private int _index = -1;
        public int Index
        {
            get { return _index; }
            set {_index=value;}
        }

        public Stack()
        {
            Elements = new T[Capacity];
        }

        public Stack(int capacity)
        {
            Capacity = capacity;
            Elements = new T[Capacity];
        }

        public void Push(T element)
        {
            if (this.Length == Capacity)
            {

            }
            Index++;
            Elements[Index] = element;
        }

        public T Pop()
        {
            if (this.Length < 1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T element = Elements[Index];
            Elements[Index] = default(T);
            Index--;
            return element;
        }

        public T Peek()
        {
            if (this.Length < 1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return Elements[Index];
        }

        public List<T> print()
        {

            List<T> newList = new List<T>();
            for(int i=0;i<Length;i++)
            {
                newList.Add(Elements[i]);
            }
            return newList;
        }

    }
}
