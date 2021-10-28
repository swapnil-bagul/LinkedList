using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object
            LinkedList list = new LinkedList();
            //adding element using InsertFirst() method
            list.Add(11);
            list.Add(12);
            list.Add(13);

            list.InsertFirst(70); 
            list.InsertFirst(30);
            list.InsertFirst(56);
          
            // Displaying linkedlist
            list.Display();
          
        }
    }
}
