using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace LeetCode
{
    public class Arrays
    {
        public int[] TwoSumReturnsIndexes(int[] nums, int sum)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            //for (int i=0; i <nums.Length; i++)
            //{
            //    dict.Add(i, nums[i]);
            //}

            for (int i = 0; i < nums.Length; i++)
            {
                int compliment = sum - nums[i];
                var key = dict.FirstOrDefault(x => x.Value == compliment).Key;
                if (dict.ContainsValue(compliment) && key != i)
                {
                    return new int[]{i, key};
                }
                dict.Add(i, nums[i]);
            }
            return null;
        }


        public IList<string> SummaryRanges(int[] nums)
        {

            var result = new List<string>();

            if (nums.Length < 1)
            {
                return result;
            }

            if (nums.Length == 1)
            {
                string resultString = nums[0].ToString();
                result.Add(resultString);
                return result;
            }

            int lowerIndex = 0;
            int higherIndex = 0;

            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i + 1] == nums[i] + 1)
                {
                    higherIndex += 1;
                }

                else if ((nums[i + 1] != nums[i] + 1))
                {
                    string resultString;
                    if (lowerIndex == higherIndex)
                    {
                        resultString = nums[lowerIndex].ToString();
                        result.Add(resultString);
                    }
                    else
                    {
                        resultString = nums[lowerIndex] + "->" + nums[higherIndex];
                        result.Add(resultString);
                    }

                    lowerIndex = higherIndex + 1;
                    higherIndex = lowerIndex;
                }

                if (nums[i+1] == nums[nums.Length - 1])
                {
                    string resultString;
                    if (lowerIndex == higherIndex)
                    {
                        resultString = nums[lowerIndex].ToString();
                        result.Add(resultString);
                    }
                    else
                    {
                        resultString = nums[lowerIndex] + "->" + nums[higherIndex];
                        result.Add(resultString);
                    }
                }
            }

            return result;
        }

        public int[] ReplaceElements(int[] arr)
        {


            if (arr.Length == 1)
            {
                arr[0] = -1;
                return arr;
            }

            for (int i=0; i< arr.Length -1; i++)
            {
                arr[i] = FindTheGreatestElement(arr.Skip(i+1).ToArray());
            }

            arr[arr.Length - 1] = -1;
            return arr;

        }

        public int FindTheGreatestElement(int[] array)
        {
            int greatestElement = array[0];
            for (int j=0; j< array.Length; j++)
            {
                if (greatestElement < array[j])
                {
                    greatestElement = array[j];
                }
            }

            return greatestElement;
        }

        public int[] SumZero(int n)
        {
            int[] result = new int[n];

            if (n == 1)
            {
                result[0] = 0;
                return result;
            }

            if (n % 2 != 0)
            {
                result[(result.Length - 1) / 2] = 0;
            }

            int i = (result.Length - 2) / 2;
            int j = (result.Length + 1) / 2;
            int num = 1;
            while (i >= 0 && j <= (result.Length - 1))
            {
                result[i] = num;
                result[j] = num * -1 ;
                num += 1;
                i--;
                j++;
            }


            return result;
        }

        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {

            int result = 0;

            int i = 0;
            while (i < arr.Length - 2)
            {
                int j = i + 1;
                while (j < arr.Length - 1)
                {
                    int k = j + 1;
                    while (k < arr.Length)
                    {

                        if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                        {
                            result++;
                        }
                        k++;
                    }
                    j++;
                }

                i++;
            }
            return result;
        }

        public int LargestAltitude(int[] gain)
        {

            int maxAlt = 0;
            int i = 0;

            while (i < gain.Length)
            {
                if (i == 0)
                {
                    if (gain[i] > maxAlt)
                    {
                        maxAlt = gain[i];
                    }
                }

                else 
                {
                    gain[i] = gain[i - 1] + gain[i];
                    if (gain[i] > maxAlt)
                    {
                        maxAlt = gain[i];
                    }
                }
                i++;
            }

            return maxAlt;
        }

        public int SumOddLengthSubarrays(int[] arr)
        {

            int res = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currSum = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    currSum += arr[j];

                    if ((j - i + 1) % 2 != 0)
                        res += currSum;
                }
            }

            return res;
        }

        public int[] CreateTargetArray(int[] nums, int[] index)
        {

            int[] target = new int[nums.Length];
            int i = 0;

            while (i < nums.Length)
            {
                if (index[i] < i)
                {
                    int k = i;
                    while (k >= index[i])
                    {
                        if (i != nums.Length - 1)
                        {
                            target[k + 1] = target[k];
                        }

                        k--;
                    }
                }
                target[index[i]] = nums[i];
                i++;
            }

            return target;

        }

        public int[] DecompressRLElist(int[] nums)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int freq = nums[i];
                int value = nums[i + 1];
                int k = 0;
                while (k < freq)
                {
                    result.Add(value);
                    k++;
                }
                i++;
            }
            return result.ToArray();
        }

        public int NumIdenticalPairs(int[] nums)
        {
            int i = 0;
            int count = 0;

            while (i < nums.Length)
            {
                int j = nums.Length - 1;
                while (j > i)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                    j--;
                }

                i++;
            }
            return count;
        }

        public bool IsMonotonic(int[] A)
        {
            int i = 0;
            int j = 1;
            bool increasing = false;

            while (j < A.Length)
            {
                if (i == 0 && A[i] > A[j])
                {
                    increasing = true;
                }

                if (increasing && !((A[j] <= A[i]) || (A[j] == A[i])))
                {
                    return false;
                }
                else if (!((A[j] >= A[i]) || (A[j] == A[i])))
                {
                    return false;
                }
                i++;
                j++;
            }

            return true;
        }

        public int MaxProfit(int[] prices)
        {

            int i = 0;
            int j = i + 1;
            int maxProfit = 0;

            while (i < prices.Length - 1)
            {

                while (j < prices.Length)
                {
                    if (prices[j] > prices[i])
                    {
                        maxProfit += prices[j] - prices[i];
                    }
                    j++;
                }
                i++;

            }
            return maxProfit;
        }

        public void MoveZeroes(int[] nums)
        {
            

            if (nums.Length > 0)
            {
                int i = 0;
                int j = i + 1;
                while (j < nums.Length)
                {
                    if (nums[i] == 0)
                    {
                        if (nums[j] != 0)
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            i++;
                        }
                        else
                        {
                            j++;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }

            }
        }

        public int[] PlusOne(int[] digits)
        {


            if (digits[digits.Length - 1] < 9)
            {
                digits[digits.Length - 1] = digits[digits.Length - 1] + 1;
            }
            else
            {
                int i = digits.Length - 1;
                if (digits.Length == 1 && digits[0] == 9)
                {
                    return new int[] { 1, 0 };
                }
                else if (digits.Length > 1)
                {
                    while (i > 0)
                    {
                        digits[i] = 0;
                        if (digits[i - 1] != 9)
                        {
                            digits[i - 1] = digits[i - 1] + 1;
                            break;
                        }
                        else if (i - 1 == 0 && digits[i - 1] == 9)
                        {
                            digits[i] = 0;
                            digits[i - 1] = 0;
                            var arr = new int[digits.Length + 1];
                            digits.CopyTo(arr, 1);
                            arr[0] = 1;
                            return arr;
                        }
                        i--;
                    }
                }
            }
            return digits;
        }

        public int[] FindErrorNums(int[] nums)
        {
            int[] result = new int[2];

            int duplicate = 0;
            HashSet<int> map = new HashSet<int>();
            int length = nums.Length;
            int expected = 1;
            int actual = 1;

            for (int j=0; j< nums.Length; j++)
            {
                expected += j + 1;
                actual += nums[j];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.Contains(nums[i]))
                {
                    duplicate = nums[i];
                    break;
                }
                else
                {
                    map.Add(nums[i]);
                }
            }
            result[0] = duplicate;
            result[1] = Math.Abs(expected - (actual-duplicate));

            return result;
        }

        public bool ContainsPattern(int[] arr, int m, int k)
        {

            int repeatCount = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    repeatCount += 1;
                    if (repeatCount >= k)
                    {
                        return true;
                    }
                }
                else if (arr[i] != arr[i + 1])
                {
                    repeatCount = 0;
                }
            }

            if (m>1)
            {
                int j = 0;
                while (j<=arr.Length-m)
                {

                }

            }

            return false;

        }

        public bool IsAnagram(string word1, string word2)
        {
            var word1Array = word1.ToCharArray();
            var word2Array = word2.ToCharArray();
            if (word1Array.Length != word2Array.Length)
            {
                return false;
            }

            int i = 0;
            
            while (i< word1Array.Length)
            {
                int j = i;
                while (j< word2Array.Length)
                {
                    if (word1Array[i] == word2Array[j])
                    {
                        var temp = word2Array[j];
                        word2Array[j] = word2Array[i];
                        word2Array[i] = temp;
                    }

                    j++;
                }

                i++;
            }
            if (new string(word1Array) == new string(word2Array))
            {

                return true;
            }
            return false;
        }

        public int FindMaxSum(int[] arr)
        {
            int i = 0;
            int j = 1;
            int result1 = 0;
            int result2 = 0;
            while (i< arr.Length || j< arr.Length)
            {
                result1 += arr[i];
                if (!(j >= arr.Length))
                {
                    result2 += arr[j];
                }
                
                i+=2;
                j+=2;
            }

            if (result1 > result2)
            {
                return result1;
            }

            return result2;
        }

        int result = 0;

        
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;

            }
        }



        public int MinDiffInBST(TreeNode root)
        {
            if (root == null || (root.right == null && root.left == null))
            {
                return int.MaxValue;
            }
            int leftDistance = int.MaxValue;
            if (root.left != null)
            {
                leftDistance = root.val - root.left.val;
            }
            int rightDistance = int.MaxValue;
            if (root.right != null)
            {
                rightDistance = root.right.val - root.val;
            }

            if (leftDistance < rightDistance)
            {
                if ((result != 0 && leftDistance < result) || (result == 0))
                {
                    result = leftDistance;
                }
            }
            else
            {
                if ((result != 0 && rightDistance < result) || (result == 0))
                {
                    result = rightDistance;
                }
            }

            MinDiffInBST(root.left);
            MinDiffInBST(root.right);

            return result;
        }


        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            if (root.left != null || root.right != null)
            {
                if (root.left?.val >= root?.val || root.right?.val <= root?.val)
                {
                    return false;
                }
            }

            TreeNode rightLeftNode = root.right;
            while (rightLeftNode != null && rightLeftNode.left != null)
            {
                if (root.val >= rightLeftNode?.right?.val || root.val >= rightLeftNode?.left?.val)
                {
                    return false;
                }
                rightLeftNode = rightLeftNode.left;
            }

            TreeNode leftRightNode = root.left;
            while (leftRightNode != null && leftRightNode.right != null)
            {
                if (root.val <= leftRightNode?.right?.val || root.val <= leftRightNode?.left?.val)
                {
                    return false;
                }
                leftRightNode = leftRightNode.right;
            }

            return (IsValidBST(root.left) && IsValidBST(root.right));

        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();

            int i = 0;
            int j = 0;
            double median = 0;
            while (i < nums1.Length || j < nums2.Length)
            {
                if (i < nums1.Length && j < nums2.Length)
                {
                    if (nums1[i] < nums2[j])
                    {
                        result.Add(nums1[i]);
                        i++;
                    }
                    else
                    {
                        result.Add(nums2[j]);
                        j++;
                    }
                }
                else if (i >= nums1.Length && j < nums2.Length)
                {
                    result.Add(nums2[j]);
                    j++;
                }

                else if (j >= nums2.Length && i < nums1.Length)
                {
                    result.Add(nums1[i]);
                    i++;
                }
            }
            int length = result.Count();

            if (length % 2 == 0)
            {
                double num = result[(length - 2) / 2] + result[length / 2];
                median = num / 2;
            }
            else
            {
                median = result[(length - 1) / 2];
            }

            return median;
        }

        //public int MyAtoi(string s)
        //{
        //    List<char> result = new List<char>();
        //    char[] sArray = s.ToCharArray();
        //    Dictionary<char, int> storage = new Dictionary<char, int>();

        //    storage.Add('-', 1);
        //    for (int k = 2; k <= 11; k++)
        //    {
        //        storage.Add((char)k, k);
        //    }

        //    for (int i = 0; i < sArray.Length; i++)
        //    {
        //        if (storage.ContainsKey(sArray[i]))
        //        {
        //            result.Add(sArray[i]);
        //        }
        //    }
        //    var resultCharArray = result.ToArray();

        //    return Convert.ToInt32(new string(resultCharArray));
        //}

        public bool WordBreak(string s, IList<string> wordDict)
        {
            int length = s.Length;
            bool[] Dp = new bool[length + 1];

            Dp[0] = true;

            for (int i = 1; i <= length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int substringLength = 0;
                    if (i == length)
                    {
                        substringLength = i - j;
                    }
                    else
                    {
                        substringLength = i - j + 1;
                    }

                    bool isTrue = wordDict.Contains(s.Substring(j, substringLength));
                    if (Dp[j] && isTrue)
                    {
                        Dp[i] = true;
                        break;
                    }
                }
            }
            return Dp[length];
        }

        public void Rotate(int[][] matrix)
        {

            int[,] transpose = new int[matrix.Length, matrix[0].Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {

                    transpose[j,i] = matrix[i][j];
                }
            }
            int bp = 0;
            int ep = matrix.Length - 1;
            while (bp <= ep)
            {
                for (int m = 0; m < matrix[0].Length; m++)
                {
                    matrix[m][bp] = transpose[m,ep];
                }
                bp++;
                ep--;
            }

        }

        public int FindKthLargest(int[] nums, int k)
        {
            if (nums == null)
            {
                return 0;
            }
            
            if(nums.Length == 1)
            {
                return nums[0];
            }

            Array.Sort(nums);
            int index = nums.Length - k;
            return nums[index];
        }

    }
}
