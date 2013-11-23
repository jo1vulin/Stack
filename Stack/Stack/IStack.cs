using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    interface IStack<T>
    {
        
        //Remove last element from stack
        T removeElement();

        //View last element from stack
        T viewElement();

        //Print all elements from stack
        List<T> printAllElements();

        //Add element to stack
        void addElement(T element);

        //Clear stack
        void clearStack();

        //Expose getter in interface
        int Length { get; }

    }
}
