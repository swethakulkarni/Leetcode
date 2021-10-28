using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Palindrome
    {
        public string LongestPalindrome(string s)
        {

            string result = "";

            if (s.Length == 1)
            {
                return s;
            }

            int i = 0;
            int j = s.Length - 1;

            while (j >= i)
            {
                string subInput = s.Substring(i, (j-i)+1);
                if (IsPalindrome(subInput))
                {
                    if (result.Length < subInput.Length)
                    {
                        result = subInput;
                    }
                }
                j--;
                if (i == j)
                {
                    i++;
                    j = s.Length - 1;
                }
            }

            return result;
        }

        public bool IsPalindrome(string input)
        {

            char[] arr = input.ToCharArray();
            int k = 0;
            int l = arr.Length - 1;
            while (k <= l)
            {

                if (arr[k] != arr[l])
                {
                    return false;
                }
                k++;
                l--;
            }
            return true;
        }
    }
}
