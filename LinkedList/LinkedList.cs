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

        // Remove Last Element
        public void RemoveLast()  
        {
            Node new_node = this.head; 

            //Checking Last Element is Null Using While loop
            while (new_node.next.next != null)  
            {
                new_node = new_node.next; 
            }
            new_node.next = null;

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
