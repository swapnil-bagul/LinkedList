﻿using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object
            LinkedList list = new LinkedList();

            //Adding element
            list.Add(56); 
            list.Add(70);
            list.Display();

            //inserting Element
            list.InsertBetween(list.head.next ,30);

            // Displaying linkedlist
            list.Display();
          
        }
    }
}
