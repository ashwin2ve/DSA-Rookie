using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class PositiveElementsAtEvenAndNegativeAtOdd
    {
        public static void SortPositiveNegativeElementsAtEvenOdd(int[] arr)
        {
            /*Input : arr[] = {1, -3, 5, 6, -3, 6, 7, -4, 9, 10}
              Output : arr[] = {1, -3, 5, -3, 6, 6, 7, -4, 9, 10}
            URL: https://www.geeksforgeeks.org/positive-elements-at-even-and-negative-at-odd-positions-relative-order-not-maintained/
             
             * Loop through all items and check if -ve value resides at odd or positive value at even.If not, switch with i-1 or i+1
             * if the required value is available else no change
             */

            for(int i = 0; i < arr.Length; i++)
            {
                int tempValue = 0;
                if (i % 2 == 0) // Even - Positive
                {
                    if (arr[i] < 0)
                    {
                        tempValue = arr[i];
                        if (i != 0 && arr[i - 1] > 0)
                        {
                            arr[i] = arr[i - 1];
                            arr[i - 1] = tempValue;
                        }
                        else if (i < arr.Length - 1 && arr[i + 1] > 0)
                        {
                            arr[i] = arr[i + 1];
                            arr[i + 1] = tempValue;
                        }
                    }

                }
                else // Odd - Negative
                {
                    if (arr[i] > 0)
                    {
                        tempValue = arr[i];
                        if (i != 0 && arr[i - 1] < 0 )
                        {
                            arr[i] = arr[i - 1];
                            arr[i - 1] = tempValue;
                        }
                        else if (i < arr.Length - 1 && arr[i + 1] < 0)
                        {
                            arr[i] = arr[i + 1];
                            arr[i + 1] = tempValue;
                        }
                    }

                }
            }

            PrintResult.PrintArrayResult(arr);
        }
    }
}
