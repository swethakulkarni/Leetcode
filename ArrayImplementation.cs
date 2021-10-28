using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class ArrayImplementation
    {
        public ArrayImplementation(int length)
        {
            this.Length = 0;
            this.data = new object[length];
        }

        public int Length { get; set; }
        public object[] data { get; set; }

        public dynamic Get(int index)
        {
            return this.data[index];
        }

        public int Push(string item)
        {
            this.data[this.Length] = item;
            this.Length = this.Length+1;
            return Length;
        }

        public void Pop()
        {
            var lastItem = this.data[this.Length - 1];
        }
    }

    
}
