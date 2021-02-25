using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new DoublyLinkedList();

            a.AddFirst(1);
            a.AddFirst("first");
            a.AddLast("last");
            a.PrintAll();
            Console.WriteLine("=====");
            a.AddAtIndex("index", 2);
            a.PrintAll();
            Console.WriteLine("=====");
            a.FindAtIndex(1);
            a.RemoveAtIndex(1);
            a.FindAtIndex(1);
        }

    }
}
