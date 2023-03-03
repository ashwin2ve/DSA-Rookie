using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class TrappingRainWater
    {
        public static int Calculate(int[] arr)
        {
            /* Input: arr[]   = {2, 0, 2}
               Output: 2
               Input: arr[]   = {3, 0, 2, 0, 4}
               Output: 7
               Input: arr[] = {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1}
               Output: 6
            URL : https://www.geeksforgeeks.org/trapping-rain-water/
             */
            int i = 0;
            int leftMax = 0;
            int leftMaxIndex = 0;
            int rightMax = 0;
            int rightMaxIndex = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                if(leftMax < arr[i])
                {
                    leftMax = arr[i];
                    leftMaxIndex = i;
                }

                if(rightMax < arr[j])
                {
                    rightMax = arr[j];
                    rightMaxIndex = j;
                }

                i++;
                j--;
            }

            return CalculateCapacity(leftMax, rightMax, arr, leftMaxIndex, rightMaxIndex);
        }

        private static int CalculateCapacity(int leftMax, int rightMax, int[] arr, int leftMaxIndex, int rightMaxIndex)
        {
            int count = 0;
            var minValue = leftMax >= rightMax ? rightMax : leftMax;
            for (int i = leftMaxIndex + 1; i < rightMaxIndex; i++)
            {
                count = count + (minValue - arr[i]);
            }

            return count;
        }


        #region Optimized

        public static int OptimizedCalculate(int[] arr)
        {
            int leftMax = 0;
            int[] leftMaxIndex = new int[arr.Length];

            int rightMax = 0;
            int[] rightMaxIndex = new int[arr.Length];

            for(int i = 0; i < arr.Length; i++)
            {
                if(leftMax <= arr[i])
                {
                    leftMax = arr[i];                    
                }

                leftMaxIndex[i] = leftMax;
            }

            for (int i = arr.Length - 1; i >= 0; i--) 
            {
                if (rightMax <= arr[i]) 
                {
                    rightMax = arr[i];
                }

                rightMaxIndex[i] = rightMax;
            }

            int index = 0;
            int count = 0;
            while (index < arr.Length) 
            {
                var minValue = leftMaxIndex[index] < rightMaxIndex[index] ? leftMaxIndex[index] : rightMaxIndex[index];
                count = count + (minValue - arr[index]);
                index++;
            }

            PrintResult.PrintResultGeneric(count);
            return count;
        }

        #endregion
    }
}
