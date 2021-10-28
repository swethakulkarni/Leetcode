using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeetCode
{
    public class StackUsingLinkedList
    {
        StackNode bottom = null;
        StackNode top = null;
        private int length = 0;
        public StackUsingLinkedList()
        {
            this.bottom = null;
            this.length = 0;
            this.top = null; 

        }

        public StackNode Peek()
        {
            return this.top;
        }

        public StackUsingLinkedList Push(dynamic Value)
        {
            var newNode = new StackNode(Value);
            if (this.length == 0)
            {
                this.top = newNode;
                this.bottom = newNode;
                this.length += 1;
                return this;
            }

            newNode.Next = this.top;
            this.top = newNode;
            this.length += 1;
            return this;
        }

        public StackUsingLinkedList Pop()
        {
            this.top = this.top.Next;
            this.length -= 1;
            return this;
        }
    }

    public class StackNode
    {
        public StackNode(dynamic value)
        {
            this.Value = value;
            this.Next = null;
        }

        public dynamic Value { get; set; }
        public StackNode Next { get; set; }
    }

}
