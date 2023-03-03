using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class MaximumCircularSubarraySum
    {
        public static void Print(int[] arr)
        {
            /* URL: https://www.geeksforgeeks.org/maximum-contiguous-circular-sum/
             *  Input: a[] = {8, -8, 9, -9, 10, -11, 12}
                Output: 22 (12 + 8 - 8 + 9 - 9 + 10)

                Input: a[] = {10, -3, -4, 7, 6, 5, -4, -1} 
                Output:  23 (7 + 6 + 5 - 4 -1 + 10) 
                
                Input: a[] = {-1, 40, -14, 7, 6, 5, -4, -1}
                Output: 52 (7 + 6 + 5 - 4 - 1 - 1 + 40)

                Input: { 2, 3, -4 }
                Output: 5

                Input: { 5, -2, 3, 4 }
                Output: 12

                Input: { 8, -4, 3, -5, 4 }
                Output: 12

                Input: { -3, 4, 6, -2 }
                Output: 10
             */

            int maxSum = 0;
            int currentValue = 0;
            int outerIndex = 0;
            while (outerIndex < arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    currentValue = currentValue + arr[i];
                    if (currentValue > 0)
                    {
                        if (maxSum < currentValue)
                        {
                            maxSum = currentValue;
                        }
                    }
                    else
                    {
                        currentValue = 0;
                    }
                }

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    var temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }

                currentValue = 0;
                outerIndex++;
            }

            PrintResult.PrintResultGeneric(maxSum);
        }
    }
}
