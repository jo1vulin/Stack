using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    interface IStack<T>
    {
        

        T removeElement();
        T viewElement();
        List<T> printAllElements();
        int getLength();
        void addElement(T element);
    }
}
