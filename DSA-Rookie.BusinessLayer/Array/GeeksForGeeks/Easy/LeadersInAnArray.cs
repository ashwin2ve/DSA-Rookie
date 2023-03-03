using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class LeadersInAnArray
    {
        /* URL : https://www.geeksforgeeks.org/leaders-in-an-array/
             * I: {16, 17, 4, 3, 5, 2}; O: 17, 5 and 2 (Checks if value is bigger than its right elements).
             */

        #region Naive Method
        public static void Print(int[] arr)
        {                        
            ArrayList arrayList = new ArrayList();
            for(int i = 0; i < arr.Length; i++)
            {
                bool isBigger = true;
                for(int j = i+1; j< arr.Length; j++)
                {
                    if(arr[i] < arr[j])
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    arrayList.Add(arr[i]);
                }
            }

            arrayList.PrintResult();
        }

        #endregion

        #region Optimized
        public static void OptimizedPrint(int[] arr)
        {
            ArrayList optimizedArrayList = new ArrayList();
            int max = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i == arr.Length - 1)
                {
                    optimizedArrayList.Add(arr[i]);
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                    optimizedArrayList.Add(arr[i]);
                }
            }

            optimizedArrayList.PrintResult();
        }
        #endregion
    }
}
