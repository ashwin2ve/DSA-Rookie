using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class MaximumSumAlongAllRotationOfArray
    {
        public void MaximumSumAlongAllRotation(int [] arr)
        {
            /* Input: arr[] = {8, 3, 1, 2}
               Output: 29
               Explanation: Lets look at all the rotations,
               {8, 3, 1, 2} = 8*0 + 3*1 + 1*2 + 2*3 = 11
               {3, 1, 2, 8} = 3*0 + 1*1 + 2*2 + 8*3 = 29
               {1, 2, 8, 3} = 1*0 + 2*1 + 8*2 + 3*3 = 27
               {2, 8, 3, 1} = 2*0 + 8*1 + 3*2 + 1*3 = 17
               
               Input: arr[] = {3, 2, 1}
               Output: 7
               Explanation: Lets look at all the rotations,
               {3, 2, 1} = 3*0 + 2*1 + 1*2 = 4
               {2, 1, 3} = 2*0 + 1*1 + 3*2 = 7
               {1, 3, 2} = 1*0 + 3*1 + 2*2 = 7
            URL: https://www.geeksforgeeks.org/maximum-sum-iarri-among-rotations-given-array/
            */

            int sum = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                int mulValue = 0;
                int tempValue = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    mulValue = mulValue + (arr[j] * j); 
                    if(j == 0)
                    {
                        tempValue = arr[j];
                    }

                    if(j == arr.Length - 1)
                    {
                        arr[j] = tempValue;
                    }
                    else
                    {
                        arr[j] = arr[j + 1];
                    }
                }

                if (sum < mulValue)
                {
                    sum = mulValue;
                }
            }

            PrintResult.PrintIntResult(sum);
        }
    }
}
