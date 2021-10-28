using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        // Create head reference variable
        internal Node head;

        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linkedlist", node.data);
        }

        // Search Element in List
        public void SearchElement(int data) 
        {
            
            while (this.head != null)
            {
                if (this.head.data == data)
                {
                    Console.WriteLine("Element is Found");
                }
                //Incrementation Of Head
                this.head = this.head.next;
                
            }

        }


        //Displaying List
        public void Display ()
        {
            Console.WriteLine("LinkedList Element");

            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
