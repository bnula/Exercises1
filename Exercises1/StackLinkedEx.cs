using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1
{
    class StackLinkedEx
    {
        private class Node
        {
            internal object data;
            internal Node next;
        }

        Node head = new Node();
        int length = 0;

        public void Push(object data)
        {
            Node addNode = new Node
            {
                data = data,
                next = head
            };
            head = addNode;

            length++;
        }

        public object Pop()
        {
            if (length == 0)
            {
                Console.WriteLine("Empty Stack");
                return null;
            }
            object item = head.data;
            head = head.next;
            length--;
            return item;
        }

        public object Peek()
        {
            if (length == 0)
            {
                Console.WriteLine("Empty Stack");
                return null;
            }
            object item = head.data;
            return item;
        }

    }
}
