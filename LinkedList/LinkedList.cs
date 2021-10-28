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

        //Insert Element Between Two Element
        public void InsertBetween(Node beforeElement ,int data )
        {
            beforeElement = this.head;

            // Create Object 
            Node new_node = new Node(data);
            new_node.next = beforeElement.next;
            beforeElement.next = new_node;

            Console.WriteLine("{0} inserted into linkedlist", new_node .data);
        }

        //Displaying List
        public void Display ()
        {
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
