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
            IStack<int> stack = new Stack<int>(10);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Add element " + i);
                stack.addElement(i);
                Console.WriteLine("New length is: " + stack.getLength());

            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("View last added element " + stack.viewElement());
                Console.WriteLine("Remove last added element " + stack.removeElement());
                Console.WriteLine("New length is " + stack.getLength());

            }

            try
            {
                stack.viewElement();
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine("Error " + exc.Message);
            }

            try
            {
                stack.removeElement();
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine("Error " + exc.Message);
            }

            Console.WriteLine("Press any key to continue ...");
            Console.ReadLine();



        }
    }
}

