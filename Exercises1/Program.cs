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
            var a = new SinglyLinkedList();
            a.AddFirst(12);
            a.AddFirst(14);
            a.PrintAllNodes();
            Console.WriteLine("====");
            a.AddLast("test");
            a.PrintAllNodes();
            Console.WriteLine("====");
            a.InsertAt("insert", 1);
            a.PrintAllNodes();
            Console.WriteLine("====");
            a.RemoveAt(1);
            a.PrintAllNodes();
        }

    }
}
