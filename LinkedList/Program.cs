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

            //Adding element
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();

            // Searching & Inserting Element 
            list.InsertElement(30, 40);

            //Displaying Element
            list.Display();


        }
    }
}
