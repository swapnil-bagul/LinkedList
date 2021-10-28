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
            //Create Object new_node of Node Class
            Node new_node = new Node(data); 
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                //assign head to temp reference variable
                Node temp = head;
                while (temp.next !=null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("{0} inserted into linkedlist", new_node.data);
        }

        //UC2
        //Added element 70-30-56
        //sequence is 56-70-30
        public void InsertFirst(int data)
        {
            //Create Object new_node of Node Class
            Node new_node = new Node(data);

            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("inserted into linkedlist" + new_node.data);

        }
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
