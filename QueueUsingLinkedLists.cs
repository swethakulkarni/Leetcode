using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class QueueUsingLinkedList
    {
        StackNode first = null;
        StackNode last = null;
        private int length = 0;
        public QueueUsingLinkedList()
        {
            this.first = null;
            this.length = 0;
            this.last = null;

        }

        public StackNode Peek()
        {
            return this.last;
        }

        public QueueUsingLinkedList EnQueue(dynamic Value)
        {
            var newNode = new StackNode(Value);
            if (this.length == 0)
            {
                this.first = newNode;
                this.last = newNode;
                this.length += 1;
                return this;
            }

            this.last.Next = newNode;
            this.last = newNode;
            this.length += 1;
            return this;
        }

        public QueueUsingLinkedList Dequeue()
        {
            if (this.length == 0)
            {
                return null;
            }

            if (this.length == 1)
            {
                this.first = null;
                this.last = null;
                this.length -= 1;
            }

            if (this.length > 1 )
            {
                this.first = this.first.Next;
                this.length -= 1;
            }
            return this;
        }
    }

}
