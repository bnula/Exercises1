using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1
{
    class QueueEx
    {
        private class Node
        {
            internal object data;
            internal Node next;
        }

        Node first = new Node();
        Node last = new Node();
        int length = 0;

        public void Enqueue(object data)
        {
            Node addNode = new Node
            {
                data = data
            };

            if (length == 0)
            {
                first = addNode;
                last = addNode;
            }
            else
            {
                last.next = addNode;
                last = addNode;
            }
            length++;

        }

        public object Dequeue()
        {
            if (first == null)
            {
                Console.WriteLine("Empty Queue");
                return null;
            }
            if (first == last)
            {
                last = null;
            }
            object item = first.data;
            first = first.next;
            length--;
            return item;
        }

        public object Peek()
        {
            if (first == null)
            {
                Console.WriteLine("Empty Queue");
                return null;
            }
            object item = first.data;
            return item;
        }

    }
}
