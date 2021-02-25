using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1
{
    public class DoublyLinkedList
    {
        private class Node
        {
            internal object data;
            internal Node previous;
            internal Node next;
        }
        
        private Node head;
        private int length = 0;

        public void PrintAll()
        {
            Node current = head;

            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void RemoveAtIndex(int index)
        {
            Node current = head;
            int i = 0;

            while (i < index)
            {
                current = current.next;
                i++;
            }

            current.previous.next = current.next.previous;
        }

        public void FindAtIndex(int index)
        {
            Node current = head;
            int i = 0;

            while (i < index)
            {
                current = current.next;
                i++;
            }

            Console.WriteLine(current.data);
        }

        public void AddAtIndex(object data, int index)
        {
            if (index == 0)
            {
                AddFirst(data);
                return;
            }
            if (index >= length)
            {
                AddLast(data);
                return;
            }

            Node addNode = new Node
            {
                data = data
            };

            Node current = head;
            int i = 0;

            while (i < index)
            {
                current = current.next;
                i++;
            }

            current.previous.next = addNode;
            current.previous = addNode;
            addNode.next = current;
            addNode.previous = current.previous;

            length++;
        }

        public void AddFirst(object data)
        {
            Node addNode = new Node
            {
                data = data,
            };

            if (length == 0)
            {
                head = addNode;
                length++;
                return;
            }

            addNode.next = head;
            head.previous = addNode;
            head = addNode;

            length++;
        }

        public void AddLast(object data)
        {
            Node addNode = new Node
            {
                data = data
            };

            Node current = head;

            while (current.next != null)
            {
                current = current.next;
            }

            current.next = addNode;
            addNode.previous = current;

            length++;
        }
    }
}
