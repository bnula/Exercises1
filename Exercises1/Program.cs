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
            var a = new BinarySearchTree();
            var res = a.Find(25);
            Console.WriteLine(res);
            a.Insert(50);
            a.Insert(40);
            a.Insert(30);
            a.Insert(20);
            a.Insert(10);
            a.Insert(60);
            a.Insert(70);
            a.Insert(80);
            a.Insert(90);
            a.Insert(33);
            res = a.Find(30);
            Console.WriteLine(res.value);
            Console.WriteLine(res.left.value);
            Console.WriteLine(res.right.value);
        }

    }
}
