using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Runner 
    {
        public static void Main(string[] args)
        {
            StackInterface<int> test = new Stack<int>(10);

            test.Push(10);
            test.Push(11);
                       

            Console.WriteLine(test.Peek());
            test.Pop();
            Console.WriteLine(test.Peek());
            Console.ReadLine();
            //Console.WriteLine(test.Length);
            List<int> testLista = test.print();
            foreach (var item in testLista)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
          
        }
    }
}
