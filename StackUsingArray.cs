using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class StackUsingArray
    {
        private string[] stack = new String[]{};
        private int Length = 0;
        public StackUsingArray(int size)
        {
            stack = new string[size];
            this.Length = 0;
        }

        public StackUsingArray Push(string value)
        {
            if (Length < stack.Length)
            {
                stack[Length] = value;
                Length += 1;
            }

            return this;
        }

        public StackUsingArray Pop()
        {
            if (stack[0] != null && Length < stack.Length) 
            {
                stack[Length] = null;
                this.Length -= 1;
            }
            return this;
        }

        public string Peek()
        {
            if (stack[0] != null && Length < stack.Length)
            {
                return stack[Length];
            }

            return null;
        }
    }
}
