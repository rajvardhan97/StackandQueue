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
            StackandQueue stack = new StackandQueue();

            Console.WriteLine("Press 1 for Stack\nPress 2 for Queue\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
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
                    break;
                case 2:
                   stack.Enqueue(56);
                    stack.Enqueue(30);
                    stack.Enqueue(70);
                    Console.WriteLine("Queue:");
                    stack.DisplayQueue();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            
        }
    }
}