using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1
{
    

    public class SinglyLinkedList
    {
        private class Node
        {
            public Object data;
            public Node next;
        }

        private Node head;
        public int length = 0;

        public void PrintAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void RemoveAt(int index)
        {
            if (index > length)
            {
                Console.WriteLine("index number too big");
                return;
            }
            Node current = head;
            Node prevNode = head;
            int i = 0;
            while (i < index)
            {
                prevNode = current;
                current = current.next;
                i++;
            }
            prevNode.next = current.next;

        }

        public void FindAt(int index)
        {
            Node current = head;
            int i = 0;
            while (i< index)
            {
                current = current.next;
                i++;
            }
            Console.WriteLine(current.data);
        }

        public void InsertAt(object data, int index)
        {
            if (index == 0)
            {
                AddFirst(data);
                return;
            }
            Node addNode = new Node 
            { 
                data=data
            };
            Node current = head;
            Node prevNode = new Node();
            int i = 0;
            while (i < index)
            {
                prevNode = current;
                current = current.next;
                i++;
            }
            prevNode.next = addNode;
            addNode.next = current;
        }

        public void AddFirst(object data)
        {
            Node addNode = new Node();
            addNode.data = data;
            addNode.next = head;

            head = addNode;
            length++;
        }

        public void AddLast(object data)
        {
            Node addNode = new Node();
            addNode.data = data;

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = addNode;
            length++;
        }
    }
}
