using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class SplitArrayAndAddToEnd
    {
        public void SplitArrayAndAddFirstPartToEnd(int[] arr, int indexToSplit) 
        {
            /* Input : arr[] = {12, 10, 5, 6, 52, 36}, k = 2
               Output : arr[] = {5, 6, 52, 36, 12, 10}
             URL : https://www.geeksforgeeks.org/split-array-add-first-part-end/
             * AntiClockwise rotation as per k times
             * Preserve 0 index value in tempVariable
             */

            if (indexToSplit > arr.Length) 
            {
                Console.WriteLine("Index out of bound");
                return;
            }

            if (indexToSplit != arr.Length)
            {
                for (int i = 0; i < indexToSplit; i++)
                {
                    int zeroIndexValue = arr[0];
                    for (int j = 0; j < arr.Length-1; j++)
                    {
                        arr[j] = arr[j + 1];                        
                    }

                    arr[arr.Length - 1] = zeroIndexValue;
                }
            }

            for (int i = 0; i < arr.Length; i++) 
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
