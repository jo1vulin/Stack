using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    interface StackInterface<T>
    {
        

        T Pop();
        T Peek();
        List<T> print();
        void Push(T element);
    }
}
