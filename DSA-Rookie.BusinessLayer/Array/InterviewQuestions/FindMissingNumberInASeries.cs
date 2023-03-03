using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class FindMissingNumberInASeries
    {
        public static void Print(int[] arr)
        {
            /* Find Missing numbers.
             * Input : 6,9,5,3,11 ; Output: 4,7,8,10
             * Input : 1, 6, 9, 5, 3, 11, 13 ; Output: 2,4,7,8,10,12
             */

            Sort(arr); //3,5,6,9,11
            ArrayList arrayList = new ArrayList();
            for (int i = 1; i < arr.Length; i++)
            {
                var temp = arr[i - 1];
                while (arr[i] - temp > 1 && temp < arr[i])
                {
                    arrayList.Add(++temp);
                }
            }

            PrintResult.PrintArrayListResult(arrayList);
        }

        public static void Optimized(int[] arr)
        {            
            arr.SelectionSort(0, arr.Length);
            int index = arr.Length - 1;
            int num = arr[index] - 1;            
            ArrayList arrayList = new ArrayList();

            while (num != arr[0])
            {
                if (num > arr[index - 1] && num < arr[index])
                {
                    arrayList.Add(num);
                }
                else if (num == arr[index - 1])
                {
                    index--;
                }

                num--;
            }

            arrayList.PrintResult();
        }        

        private static void Sort(int[] arr)
        {
            while (true)
            {
                bool isProcessing = false;

                for(int i = 1; i < arr.Length; i++)
                {
                    if(arr[i] < arr[i - 1])
                    {
                        var temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                        isProcessing = true;
                    }
                }

                if (!isProcessing)
                {
                    break;
                }
            }
        }

        
    }
}
