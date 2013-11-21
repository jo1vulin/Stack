﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    // Generic class
    public class Stack<T> : IStack<T>
    {
        private int capacity;
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        private int length;
        public int Length
        {
            get { return Index + 1; }
        }

        private T[] elements;
        protected T[] Elements
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
            T element = Elements[Index];
            Elements[Index] = default(T);
            Index--;
            return element;
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

        public int getLength()
        {
            return Length;
        }

        private void increaseCapacity()
        {
            Capacity++;
            T[] newElements = new T[Capacity];
            Array.Copy(Elements, newElements, Elements.Length);
            Elements = newElements;
        }

    }
}
