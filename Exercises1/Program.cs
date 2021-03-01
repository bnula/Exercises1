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
            Exercises3.FibonacciIterative(20);
            Console.WriteLine("=====");
            Exercises3.FibonacciRecursive(0, 1, 0, 20);
            Exercises3.ReverseStringRecursive("abcde");
        }

    }
}
