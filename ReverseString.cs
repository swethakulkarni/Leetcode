using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class ReverseString
    {
        public string BackwardString(string input)
        {
            return string.Concat(input.ToCharArray().Reverse());
        }
    } 
}
