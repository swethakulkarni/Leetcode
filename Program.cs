using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using Newtonsoft.Json;

namespace LeetCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Call the methods here
            
            //ReverseString reverseString = new ReverseString();
            //var result = reverseString.BackwardString("ahtews si eman ym");
            //TwoSum twoSum = new TwoSum();
            //var input = new int[]{ 3,2,4 };
            //var result = twoSum.TwoSumReturnsIndexes(input, 6);

           // Console.WriteLine(result.ElementAt(0)+","+ result.ElementAt(1));

            //HashTable

           HashTable hashTable = new HashTable(50);
           hashTable.Set("grapes", 10000);
           hashTable.Set("apple", 10);
           hashTable.Set("oranges", 20);
           hashTable.Set("grapes", 300);
            hashTable.GetKeys();
           var result = hashTable.Get("grapes");

           //LinkedList

            LinkedList linkedList = new LinkedList(10);
            linkedList.Append(30);
            linkedList.Append(40);
            linkedList.Append(50);
            linkedList.Prepend(0);
            linkedList.Insert(2,20);
            linkedList.Insert(0, 100);
            linkedList.Remove(2);

            //Doubly LinkedList

            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(10);
            doublyLinkedList.Append(30);
            doublyLinkedList.Append(40);
            doublyLinkedList.Append(50);
            doublyLinkedList.Prepend(0);
            doublyLinkedList.Insert(2, 20);
            doublyLinkedList.Insert(0, 100);
            doublyLinkedList.Remove(2);

            //Stack Using LinkedList

            var stack = new StackUsingLinkedList();
            stack.Push(1);
            stack.Push(2);
            var element1 = stack.Push(3);
            stack.Pop();
            var element = stack.Peek();


            //Stack using Array 

            var arrayStack = new StackUsingArray(10);
            arrayStack.Push("google");
            arrayStack.Push("amazon");
            arrayStack.Push("swetha");
            arrayStack.Push("vancouver");
            arrayStack.Push("surya");
            var surya = arrayStack.Peek();
            arrayStack.Pop();


            //Queue Using LinkedList

            QueueUsingLinkedList queueUsingLinkedList = new QueueUsingLinkedList();

            queueUsingLinkedList.EnQueue("google");
            queueUsingLinkedList.EnQueue("amazon");
            queueUsingLinkedList.EnQueue("apple");
            queueUsingLinkedList.Dequeue();
            queueUsingLinkedList.Peek();
            //Console.ReadLine();


            //Binary Search Tree

            BinarySearchTree tree = new BinarySearchTree();

            tree.Insert(9);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(20);
            tree.Insert(170);
            tree.Insert(15);
            var treeResult = tree.Insert(1);
            //var lookupResult = tree.Lookup(20);
            //var lookupNOtFound = tree.Lookup(1000);

            //var arraysCanBeEqual = new ArraysCanBeEqual();
            //int[] targetInput = new[] {1, 2, 3, 4};
            //int[] array = new[] {2, 4, 1, 3};
            //var arraysCanBeEqualResponse= arraysCanBeEqual.CanBeEqual(targetInput, array);
            //var deleteResult = tree.Delete(20);
           // var json = JsonConvert.SerializeObject(treeResult, Formatting.Indented); ;

            //var hammingDistance = new HammingDistance();
            //var hDResult = hammingDistance.HammingDistanceProblem(1,4);


            //Max number of Balls

            //var maxNumberOfBalls = new MaxNumberOfBalls();
            //int nob = maxNumberOfBalls.MaxNumberOfBallsImplementation(11,104);


            //Arrays

            var arrays = new Arrays();
            int[] input = new[] { 2,2,2,2};
            int[] resp = new int[5];

            var bstinput = new Arrays.TreeNode
            {
                val = 96,
                left = new Arrays.TreeNode
                {
                    val = 12,
                    left = null,
                    right = new Arrays.TreeNode
                    {
                        val = 13,
                        left = null,
                        right = new Arrays.TreeNode
                        {
                            val = 52,
                            left = new Arrays.TreeNode
                            {
                                val = 29,
                                left = null,
                                right = null
                            },
                            right = null
                        }
                    }
                },
                right = null
            };

            var bstinput1 = new Arrays.TreeNode
            {
                val = 90,
                left = new Arrays.TreeNode
                {
                    val = 69,
                    left = new Arrays.TreeNode
                    {
                        val = 49,
                        left = null,
                        right = new Arrays.TreeNode
                        {
                            val = 52,
                            left = null,
                            right = null
                        }
                    },
                    right = new Arrays.TreeNode
                    {
                        val = 89,
                        left = null,
                        right = null
                    }
                },
                right = null
            };

            var isValidInput = new Arrays.TreeNode
            {

            };

            var sb = new LargestSubstring();

            var p = new Palindrome();
            var lp = p.LongestPalindrome("babad");
            var sbl = sb.LengthOfLongestSubstringOnline("dvdf");
           // var atoi = arrays.MyAtoi("words and 987");

            var wb = arrays.WordBreak("leetcode", new List<string>{"leet", "code"});

            var FindMedianSortedArrays = arrays.FindMedianSortedArrays(new []{1,2}, new []{3,4});


            var bstResult = arrays.MinDiffInBST(bstinput1);

            var validBST = arrays.IsValidBST(bstinput);
            

            var maxloot = arrays.FindMaxSum(new[] { 5, 5, 10, 100, 10, 5 });
            


            Console.WriteLine(lp);
            Console.ReadLine();
        }

        //Brute Force Approach
        public static int[] TwoSum_BruteForce(int[] nums, int target)
        {
            int[] result = null;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        result = new int[] {i, j};
                        break;
                    }
                }
            }

            return result;
        }

        //Reverse Integer
        public static int Reverse(int x)
        {
            double result = 0;
            while (x > 0)
            {
                int reminder = x % 10;
                result = result * 10 + reminder;
                x = x / 10;
            }

            if (result > Int32.MaxValue || result < Int32.MinValue)
            {
                return 0;
            }

            return Convert.ToInt32(result);
        }

        //Palindrome

        //public static bool Palindrome(int x)
        //{


        //}

        public static string FindNemo()
        {
            string[] array = new[] {"Bill", "Surya", "Sandmine", "Mime", "Pikachu", "nemo", "Populo", "Pipulo"};
            string result = "";
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "nemo")
                {
                    result = "Found Nemo";
                }
            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            return result;
        }

        public static int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];

            if (nums.Length >= 1 && nums.Length <= 10000)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] <= 10000 && nums[i] >= -10000)
                    {
                        result[i] = nums[i] * nums[i];

                    }

                }
                Array.Sort(result);
                
            }

            return result;
        }

        public static int[] SortSqares(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result.Length - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        var temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            return result;
        }


        //public static bool ContainsCommonItem(char[] array1, char[] array2)
        //{
        //    if (array1.Any() && array2.Any())
        //    {
        //        for (int i = 0; i < array1.Length; i++)
        //        {
        //            for (int j = 0; j < array2.Length; j++)
        //            {
        //                if (array1[i] == array2[j])
        //                {
        //                    return true;
        //                }
        //            }
        //        }
        //    }

        //    return false;
        //}

        public static bool ContainsCommonItem(dynamic[] array1, dynamic[] array2)
        {
            //dynamic arrayObject = new ExpandoObject();
            dynamic arrayObject = new Dictionary<dynamic, bool>();
            if (array1.Any() && array2.Any())
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    arrayObject.Add(array1[i], true);
                }

                for (int j = 0; j < array2.Length; j++)
                {
                    if (arrayObject.ContainsKey(array2[j]))
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        public static bool ContainsCommonItemUsingObject(char[] array1, char[] array2)
        {
            dynamic arrayObject = new ExpandoObject();
            if (array1.Any() && array2.Any())
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    var item = array1[i];
                    arrayObject.item = true;
                }

                for (int j = 0; j < array2.Length; j++)
                {
                    //if (arrayObject)
                    //{
                    //    return true;
                    //}
                }

            }

            return false;
        }
    }
}
