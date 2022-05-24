using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("Stack: ");
            int count = stack.DisplayStack();
            for (int i = 0; i <= count; i++)
            {
                stack.Peek();
                stack.Pop();
            }
            stack.DisplayStack();
        }
    }
}