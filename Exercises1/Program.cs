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
            a.AddLast(2);
            a.AddLast(3);
            a.AddLast(4);
            a.AddLast(5);
            a.PrintAllNodes();
            Console.WriteLine("=====");
            a.Reverse();
            a.PrintAllNodes();
        }

    }
}
