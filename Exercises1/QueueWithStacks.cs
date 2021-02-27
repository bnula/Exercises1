using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1
{
    class QueueWithStacks
    {
        Stack<object> stack1;
        Stack<object> stack2;

        public void Enqueue(object data)
        {
            stack1.Push(data);
        }

        public object Dequeue()
        {
            stack2 = new Stack<object>();
            while (stack1.Count > 0)
            {
                var queueItem = stack1.Pop();
                stack2.Push(queueItem);
            }
            var item = stack2.Pop();
            stack1 = new Stack<object>();
            while (stack2.Count > 0)
            {
                var queueItem = stack2.Pop();
                stack1.Push(queueItem);
            }
            return item;
        }

        public object Peek()
        {
            stack2 = new Stack<object>();
            while (stack1.Count > 0)
            {
                var queueItem = stack1.Pop();
                stack2.Push(queueItem);
            }
            var item = stack2.Pop();
            return item;
        }
    }
}
