using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class HammingDistance
    {
        public int HammingDistanceProblem(int x, int y)
        {
            var xArray = new BitArray(BitConverter.GetBytes(x));
            var yArray = new BitArray(BitConverter.GetBytes(y));

            int difference = 0;
            int length = 0;
            if (xArray.Length < yArray.Length)
            {
                length = xArray.Length;
            }
            else
            {
                length = yArray.Length;
            }

            for (int i = 0; i < length; i++)
            {
                if (xArray[i] != yArray[i])
                {
                    difference += 1;
                }
            }
            return difference;
        }
    }
}
