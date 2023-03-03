using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class MinimumSwaps2
    {
        public static void Print(int[] arr)
        {
            /* URL : https://www.hackerrank.com/challenges/minimum-swaps-2/problem
             * Input: 4, 3, 1, 2 ; Output: 3
             * Input: 2, 3, 4, 1, 5 ; Output: 3
             * Input: 1, 3, 5, 2, 4, 6, 7 ; Output: 3
             * Input: 7, 1, 3, 2, 4, 5, 6 ; Output: 5
             */
            int count = 0;
            while (true)
            {
                bool isProcessing = false;
                for (int i = 0; i < arr.Length-1; i++) 
                {
                    if(arr[i] != i+1)
                    {
                        var temp = arr[i];
                        arr[i] = arr[temp - 1];
                        arr[temp - 1] = temp;
                        count++;
                        isProcessing = true;
                    }
                }

                if (!isProcessing)
                {
                    break;
                }
            }

            PrintResult.PrintResultGeneric(count);
        }
    }
}
