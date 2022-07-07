using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public static class MergeSortedArray
    {
        public static void MergeSortedArrays(int[] array1, int[] array2)
        {
            /* Input: arr1[] = { 1, 3, 4, 5}, arr2[] = {2, 4, 6, 8} 
               Output: arr3[] = {1, 2, 3, 4, 4, 5, 6, 8}
               Input: arr1[] = { 5, 8, 9}, arr2[] = {4, 7, 8} 
               Output: arr3[] = {4, 5, 7, 8, 8, 9}    
            URL : https://www.geeksforgeeks.org/merge-two-sorted-arrays/
             */

            int array1Index = 0;
            int array2Index = 0;
            StringBuilder finalString = new StringBuilder();
            while(array1Index < array1.Length && array2Index < array2.Length)
            {
                if(array1[array1Index] <= array2[array2Index])
                {
                    finalString.Append(array1[array1Index]);
                    array1Index++;
                }
                else
                {
                    finalString.Append(array2[array2Index]);
                    array2Index++;
                }
            }

            while(array1Index < array1.Length)
            {
                finalString.Append(array1[array1Index]);
                array1Index++;
            }

            while (array2Index < array2.Length)
            {
                finalString.Append(array2[array2Index]);
                array2Index++;
            }

            Console.WriteLine(finalString.ToString());
            Console.ReadKey();
        }
    }
}
