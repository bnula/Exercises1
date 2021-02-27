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
            var a = new QueueEx();
            a.Enqueue("test");
            Console.WriteLine(a.Peek());
            a.Enqueue(2);
            a.Enqueue(3);
            Console.WriteLine(a.Dequeue());
            Console.WriteLine(a.Dequeue());
            Console.WriteLine(a.Dequeue());
        }

    }
}
