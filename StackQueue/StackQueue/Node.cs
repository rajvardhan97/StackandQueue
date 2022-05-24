using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class StackandQueue
    {
        Node top;

        public void Push(int data)
        {
            Node Node = new Node(data);
            if (top == null)
            {
                top = Node;
            }
            else
            {
                Node.next = top;
                top = Node;
            }
        }
        public int DisplayStack()
        {
            Node temp = top;
            int count = 0;
             while(temp != null)
             {
                count++;
                Console.WriteLine("{0}", temp.data);
                temp = temp.next;
             }
            return count;
        }

        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("{0} is at the top of the stack ", this.top.data);
        }

        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }

        Node front;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (this.front == null)
            {
                this.front = node;
            }
            else
            {
                Node temp = front;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void DisplayQueue()
        {
            Node temp = front;
            if(temp == null)
            {
                Console.WriteLine("Queue is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}