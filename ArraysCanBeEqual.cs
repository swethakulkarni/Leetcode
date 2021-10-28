using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ArraysCanBeEqual
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            if (target.Length != arr.Length)
            {
                return false;
            }
            int targetElementPointer = 0;
            int arrElementIndex = 0;

            

            if (targetElementPointer == target.Length - 1 && arr[arr.Length-1] == target[target.Length-1])
            {
                return true;
            }

            return false;
        }

        //public int FindIndex(int[] arr, int TargetElement)
        //{

        //}
        

    }
}
