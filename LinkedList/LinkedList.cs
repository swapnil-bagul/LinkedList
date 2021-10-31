using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedListStack
    {
        // Create head reference variable
        internal Node top;
        //Constructor
        public LinkedListStack()
        {
            this.top = null;
        }

        //Push Element in stack
        public void Push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                node.next =null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", data);
        }

        //Displaying List
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Stack Element");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
                

        }
    }
}
