using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    // Generic class
    public class Stack<T> : IStack<T>
    {

        #region properties
        private int capacity;
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        private int length;
        public int Length
        {
            get { return length = Index + 1; }
        }

        private T[] elements;
        public T[] Elements
        {
            get { return elements; }
            set { elements = value; }
        }

        private int index = -1;
        public int Index
        {
            get { return index; }
            set {index=value;}
        }
        #endregion

        public Stack()
        {
            Elements = new T[Capacity];
        }

        public Stack(int capacity)
        {
            Capacity = capacity;
            Elements = new T[Capacity];
        }

        public void addElement(T element)
        {
            if (this.Length == Capacity)
            {
              increaseCapacity();
            }
            Index++;
            Elements[Index] = element;
        }

        public T removeElement()
        {
            if (this.Length < 1)
            {
                throw new InvalidOperationException("Stack is empty");
            }    
            Elements[Index] = default(T);
            Index--;
            return Elements[Index];

        }

        public T viewElement()
        {
            if (this.Length < 1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return Elements[Index];
        }


        public List<T> printAllElements()
        {
            
            List<T> newList = new List<T>();
            for(int i=0;i<Length;i++)
            {
                newList.Add(Elements[i]);
            }
            return newList;
        }

        //Not needed since I exposed getter in iterface
        //public int getLength()
        //{
        //    return Length;
        //}

        public void clearStack()
        {
            Array.Clear(Elements, 0, Elements.Length);
            Index = -1;
        }

        //perhaps increase to more than +1
        private void increaseCapacity()
        {
            Capacity++;
            T[] newElements = new T[Capacity];
            Array.Copy(Elements, newElements, Elements.Length);
            Elements = newElements;
        }

    }
}
