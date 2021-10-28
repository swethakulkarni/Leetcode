using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LargestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            int i = 0;
            int j = i;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            char[] sArray = s.ToCharArray();
            int length = 0;
            int tempLength = 0;


            while (i < s.Length && j < s.Length)
            {
                if ((!dict.ContainsKey(sArray[j])) || (dict.ContainsKey(sArray[j]) && dict[sArray[j]] == j))
                {
                    if ((!dict.ContainsKey(sArray[j])))
                    {
                        dict.Add(sArray[j], j);
                    }
                    tempLength++;
                    j++;
                }
                else if (dict.ContainsKey(sArray[j]) && !(dict[sArray[j]] == j))
                {
                    dict.Remove(sArray[i]);
                    if (tempLength > length)
                    {
                        length = tempLength;
                    }
                    tempLength = 0;
                    i++;
                    j = i;
                }
            }
            if (tempLength > length)
            {
                length = tempLength;
            }

            return length;
        }

        public int LengthOfLongestSubstringOnline(string s)
        {
            if (s == null || s == String.Empty)
                return 0;

            HashSet<char> set = new HashSet<char>();
            int currentMax = 0,
                i = 0,
                j = 0;

            while (j < s.Length)
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    currentMax = Math.Max(currentMax, j - i);
                }
                else
                    set.Remove(s[i++]);

            return currentMax;
        }
    }
}
