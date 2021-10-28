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

        //Inserting Element
        public void InsertElement(int data,int element)
        {
            Node temp = this.head;
            Node newNode = new Node(element);

            while (temp != null)
            {
                if (temp.data == data) // Finding Element
                {
                    Console.WriteLine("{0} Element Is Found & {1} Is Inserted In LinkedList",30,40);

                    Node temp1 = temp.next; //Inserting new Element
                    temp.next = newNode;
                    newNode.next = temp1;
                    break;
                }
                temp = temp.next;
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
