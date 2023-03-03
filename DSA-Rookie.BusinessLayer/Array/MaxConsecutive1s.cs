using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class MaxConsecutive1s
    {
        /* Input  : arr[] = {1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 1}
           Output : 4

           Input  : arr[] = {0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1}
           Output : 1
          
         * URL : https://www.geeksforgeeks.org/maximum-consecutive-ones-or-zeros-in-a-binary-array/
         */

        public static int Find(int[] arr)
        {
            int count = 0;
            int maxValue = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1) 
                {
                    count = count + 1;
                    if(maxValue < count)
                    {
                        maxValue = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            return maxValue;
        }
    }
}
