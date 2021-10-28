using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MaxNumberOfBalls
    {
        public int MaxNumberOfBallsImplementation(int lowLimit, int highLimit)
        {
            int numberOfBoxes = highLimit - lowLimit + 1;
            int numberOfBalls = 0;
            var storage = new Dictionary<int, int>();

            for (int k=1; k<=highLimit; k++)
            {
                storage.Add(k, 0);
            }

            for (var i = lowLimit; i <= highLimit; i++)
            {
                int sum = 0;

                var j = i;

                while (j > 0)
                {
                    sum = sum + j % 10;
                    j = j / 10;
                }


                if (storage.ContainsKey(sum))
                {
                    storage[sum] = storage[sum] + 1;

                    if (storage[sum] > numberOfBalls)
                    {
                        numberOfBalls = storage[sum];
                    }
                }
            }

            return numberOfBalls;
        }
    }
}
