using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class MaximumDifferenceInArrayJ_I
    {
        public static void FindMaxDifferenceInArray(int[] arr)
        {
            /*
             Input: {34, 8, 10, 3, 2, 80, 30, 33, 1}
             Output: 6  (j = 7, i = 1)

             Input: {9, 2, 3, 4, 5, 6, 7, 8, 18, 0}
             Output: 8 ( j = 8, i = 0)

             Input:  {1, 2, 3, 4, 5, 6}
             Output: 5  (j = 5, i = 0)

             Input:  {6, 5, 4, 3, 2, 1}
             Output: -1 

            URL: https://www.geeksforgeeks.org/given-an-array-arr-find-the-maximum-j-i-such-that-arrj-arri/
           */

            int value = -1;            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j >= 0; j--)
                {
                    if (i < j && arr[j] > arr[i] && value < j - i)
                    {
                        value = j - i;
                    }
                }
            }

            PrintResult.PrintResultGeneric(value);
        }
    }
}
