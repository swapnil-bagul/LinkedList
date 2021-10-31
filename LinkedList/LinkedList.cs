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

        //Peak Top Element
        public void Peek()
        {
            if (this.top==null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("The Top Element in stack is ", this.top.data);

        }

        //Delete Top Element
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletation is not Posssible");
            }
            Console.WriteLine("{0} is Poped",this.top.data );
            //decrementation of top
            this.top= this.top.next;

        }

        //Pop From stack till empty
        public void IsEmpty()
        {
            while (this.top!=null)
            {
                Peek();
                Pop();
            }
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

        //Size of LinkedList
        public void SizeOfLinkedList()
        {
            Node temp = this.head;
            int size = 0;
            while (temp != null)
            {
                
                size++;
                temp = temp.next;

            }

            Console.WriteLine("Size of LinkedList Is: "+size);
        }
    }
}
