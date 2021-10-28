using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution
    {
        public int HeightChecker(int[] heights)
        {
            int count = 0;
            List<int> heightList = new List<int>(heights);
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != heightList[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
