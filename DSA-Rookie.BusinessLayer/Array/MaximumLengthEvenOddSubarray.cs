using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class MaximumLengthEvenOddSubarray
    {
        public static void Print(int[] arr)
        {
            /*  Input: a[] = {1, 2, 3, 4, 5, 7, 9} 
                Output: 5 
                Explanation: 
                The subarray {1, 2, 3, 4, 5} has alternating even and odd elements.
                Input: a[] = {1, 3, 5} 
                Output: 0 
                Explanation: 
                There is no such alternating sequence possible. 
                
                Input: {10, 12, 14, 7,8} Output : 3
                Input: {7,10,13,14} Output: 4
                Input: {10,12,8,4} Output: 0
            URL : https://www.geeksforgeeks.org/length-of-the-longest-alternating-even-odd-subarray/
             */

            int max = 0;
            int count = 1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 2 != 0 && arr[i + 1] % 2 == 0) || (arr[i] % 2 == 0 && arr[i + 1] % 2 != 0))
                {
                    count = count + 1;
                    if(max < count)
                    {
                        max = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            PrintResult.PrintResultGeneric(count > max ? 0 : max);
        }
    }
}
