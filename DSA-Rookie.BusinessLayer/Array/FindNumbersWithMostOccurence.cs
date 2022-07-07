using System;
using System.Collections;
using System.Collections.Generic;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class FindNumbersWithMostOccurence
    {
        public static void GetNumbersWithMostOccurence(int[] arr)
        {
            //---------------------------Not Completed------------------------
            /*Input: arr[] = {3, 1, 4, 4, 5, 2, 6, 1}, 
              k = 2
              Output: 4 1
              Explanation:
              Frequency of 4 = 2
              Frequency of 1 = 2
              These two have the maximum frequency and
              4 is larger than 1.
              
              Input : 
              arr[] = {7, 10, 11, 5, 2, 5, 5, 7, 11, 8, 9},
              k = 4
              Output: 5 11 7 10
              Explanation: 
              Frequency of 5 = 3
              Frequency of 11 = 2
              Frequency of 7 = 2
              Frequency of 10 = 1
              These four have the maximum frequency and
              5 is largest among rest.
            URL : https://www.geeksforgeeks.org/find-k-numbers-occurrences-given-array/
             */

            Hashtable numbersOccurence = new Hashtable();

            for (int i = 0; i < arr.Length; i++) 
            {
                if (numbersOccurence.ContainsKey(arr[i]))
                {
                    numbersOccurence[arr[i]] = (int)numbersOccurence[arr[i]] + 1;
                }
                else
                {
                    numbersOccurence.Add(arr[i], 1);                    
                }
            }
                        
            int maxValue = 0;
            int maxValue2 = 0;
            foreach (DictionaryEntry item in numbersOccurence)
            {
                if((int)item.Value > maxValue)
                {
                    maxValue = (int)item.Key;
                }
                else if((int)item.Value > maxValue2)
                {
                    maxValue2 = (int)item.Key;
                }
            }

            Console.WriteLine();
        }
    }
}
