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

            a.Push(1);
            a.Push(2);
            a.Push(3);
            a.Peek();
            a.Pop();
            a.Pop();
            a.Peek();
        }

    }
}
