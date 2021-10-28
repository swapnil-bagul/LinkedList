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
            
            list.Append(56); 
            list.Append(30);
            list.Append(70);
          
            // Displaying linkedlist
            list.Display();
          
        }
    }
}
