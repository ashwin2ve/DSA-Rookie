using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class MeanAndMedianUnsorted
    {
        public static void CalculateMeanAndMedian(int[] arr)
        {
            /* Input  : a[] = {1, 3, 4, 2, 6, 5, 8, 7}
               Output : Mean = 4.5
                        Median = 4.5
               Sum of the elements is 1 + 3 + 4 + 2 + 6 + 
               5 + 8 + 7 = 36
               Mean = 36/8 = 4.5
               Since number of elements are even, median
               is average of 4th and 5th largest elements.
               which means (4 + 5)/2 = 4.5
               
               Input  : a[] = {4, 4, 4, 4, 4}
               Output : Mean = 4
                        Median = 4 
               URL: https://www.geeksforgeeks.org/maximum-sum-iarri-among-rotations-given-array/ 
             */

            bool isProcessing = true;
            double sumValue = 0;
            while (isProcessing)
            {
                isProcessing = false;
                int sum = 0;
                for(int i = 0; i < arr.Length; i++)
                {
                    sum = sum + arr[i];
                    if(i != arr.Length - 1 && arr[i]> arr[i + 1])
                    {
                        int tempValue = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tempValue;
                        isProcessing = true;
                    }                    
                }

                sumValue = sum;
            }

            double mean = sumValue / arr.Length;
            double median;
            if (arr.Length % 2 == 0) 
            {
                int i = arr.Length / 2;
                median = (float)(arr[i-1] + arr[i]) / 2;
            }
            else
            {
                int i = arr.Length / 2;
                median = arr[i-1];
            }

            Console.WriteLine("Mean: " + mean);
            Console.WriteLine("Median: " + median);

            Console.ReadKey();
        }
    }
}
