using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Mathematics
{
    public class PrintPrimeNumbers
    {
        public static void Print(int num)
        {
            /* Print the total prime number within num
             * Input: 10 Output: 2357
             * Input: 5 Output: 235
             */

            ArrayList arr = new ArrayList();
            if (num == 2)
            {
                arr.Add(2);
            }
            else if (num > 2)
            {
                arr.Add(2);
                arr.Add(3);
            }            

            int value = 0;
            int count = 1;
            while(value <= num)
            {
                int lowValue = (6 * count) - 1;
                int highValue = (6 * count) + 1;
                if (lowValue <= num && !IsDivisibleByPrimeNumbers(lowValue, arr))
                {
                    arr.Add(lowValue);
                }

                if(highValue <= num && !IsDivisibleByPrimeNumbers(highValue, arr))
                {
                    arr.Add(highValue);
                }

                value = highValue;
                count++;
            }

            PrintResult.PrintArrayListResult(arr);
        }

        private static bool IsDivisibleByPrimeNumbers(int num, ArrayList arr)
        {            
            for(int i = 0; i < arr.Count; i++)
            {
                int arrValue = Convert.ToInt32(arr[i]);
                if (num % arrValue == 0) 
                {
                    return true;
                }
            }
           
            return false;
        }
    }
}
