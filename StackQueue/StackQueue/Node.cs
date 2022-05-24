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
    public class Stack
    {
        Node top;

        public void Push(int data)
        {
            Node Node = new Node(data);
            if(top == null)
            {
                top = Node;
            }
            else
            {
                Node.next = top;
                top = Node;
            }
        }
        public void DisplayStack()
        {
            Node temp = top;
           // int count = 0;
            while (temp != null)
            {
               // count++;
                Console.WriteLine("{0}", temp.data);
                temp = temp.next;
            }
        }
    }
}
