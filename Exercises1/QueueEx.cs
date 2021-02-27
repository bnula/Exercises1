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

        Node head = new Node();

        public void Push(object data)
        {
            Node addNode = new Node
            {
                data = data,
                next = head
            };

            head = addNode;
        }

        public void Pop()
        {
            Console.WriteLine(head.data);
            head = head.next;
        }

        public void Peek()
        {
            Console.WriteLine(head.data);
        }

    }
}
