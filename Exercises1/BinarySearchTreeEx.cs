using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1
{
    class BinarySearchTree
    {
        internal class Node
        {
            internal int value;
            internal Node left;
            internal Node right;
        }

        Node root = new Node();

        public void Insert(int value)
        {
            Node addNode = new Node
            {
                value = value
            };
            if (root.value == 0)
            {
                root = addNode;
                return;
            };
            Node current = root;
            while (true)
            {
                if (value < current.value)
                {
                    if (current.left == null)
                    {
                        current.left = addNode;
                        return;
                    }
                    current = current.left;
                }
                else
                {
                    if (current.right == null)
                    {
                        current.right = addNode;
                        return;
                    }
                    current = current.right;
                }
            }
        }

        public void Remove(int value)
        {
            Node current = root;
            Node prev = new Node();
            while (true)
            {
                if (value < current.value)
                {
                    prev = current;
                    current = current.left;
                }
                else if (value > current.value)
                {
                    prev = current;
                    current = current.right;
                }
                else
                {
                    // leaf node
                    if (current.left == null && current.right == null)
                    {
                        if (prev.value > current.value)
                        {
                            prev.left = null;
                        }
                        else
                        {
                            prev.right = null;
                        }
                        return;
                    }
                    // no right node
                    else if (current.right == null)
                    {
                        if (prev.value > current.value)
                        {
                            prev.left = current;
                        }
                        else
                        {
                            prev.right = current;
                        }
                        return;
                    }
                    else
                    {
                        // if no left node in right node
                        if (current.right.left == null)
                        {
                            current.right.left = current.left;
                            if (prev.value > current.value)
                            {
                                prev.left = current.right;
                            }
                            else
                            {
                                prev.right = current.right;
                            }
                            return;
                        }
                        // take left node of the right node and replace the current node
                        else
                        {
                            current.right.left.left = current.left;
                            current.right.left.right = current.right;
                            if (prev.value > current.value)
                            {
                                prev.left = current.right.left;
                            }
                            else
                            {
                                prev.right = current.right.left;
                            }
                            return;
                        }
                    }
                }
            }
        }

        public Node Find(int value)
        {
            Node current = root;
            while (current != null)
            {
                if (value < current.value)
                {
                    current = current.left;
                }
                else if (value > current.value)
                {
                    current = current.right;
                }
                else
                {
                    return current;
                }
            }
            Console.WriteLine("Not Found");
            return current;
        }
    }
}
