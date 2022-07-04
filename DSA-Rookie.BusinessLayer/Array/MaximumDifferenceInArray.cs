using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class MaximumDifferenceInArray
    {
        public static void FindMaxDifferenceInArray(int[] arr)
        {
            /* Input: arr[] : {2,3,10,6,4,8,1} ; such that j>i
               Output: 8
            */

            #region Bruteforce

            int maxValue = int.MinValue;
            for (int i = 0; i < arr.Length - 1; i++) 
            {
                for(int j = i+1; j< arr.Length; j++)
                {
                    if (arr[j] - arr[i] > maxValue)
                    {
                        maxValue = arr[j] - arr[i];
                    }
                }
            }

            //PrintResult.PrintIntResult(maxValue);

            #endregion

            #region Optimized

            //2nd Way - Optimized

            int minValue = arr[0];
            int maxDifference = int.MinValue;
            for(int j = 1; j < arr.Length; j++)
            {
                if(arr[j] - minValue > maxDifference)
                {
                    maxDifference = arr[j] - minValue;
                }

                if(minValue > arr[j])
                {
                    minValue = arr[j];
                }
            }

            PrintResult.PrintIntResult(maxDifference);

            #endregion
        }
    }
}
