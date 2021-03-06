﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1
{
    class StackEx
    {
        private List<object> items = new List<object>();
        
        public void Push(object data)
        {
            items.Add(data);
        }

        public object Pop()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Empty Stack");
                return null;
            }
            var item = items[items.Count -1 ];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public object Peek()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Empty Stack");
                return null;
            }
            var item = items[items.Count - 1];
            return item;
        }
    }
}
