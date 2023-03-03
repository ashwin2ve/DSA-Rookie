using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class SalesByMatch
    {
        /* URL : https://www.hackerrank.com/challenges/sock-merchant/problem
         * Input: ar = [10, 20, 20, 10, 10, 30, 50, 10, 20] ; Output=3 (Pair of 10, 20, 10)
         * Input: 1 1 3 1 2 1 3 3 3 3 ; Output: 4
         */
        public static void Calculate(int n, List<int> ar)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for (int i = 0; i < ar.Count; i++) 
            {
                if (!keyValuePairs.ContainsKey(ar[i]))
                {
                    keyValuePairs.Add(ar[i], 1);
                }
                else
                {
                    keyValuePairs[ar[i]]++;
                }
            }

            int count = 0;
            foreach(var item in keyValuePairs)
            {
                if (item.Value / 2 > 0)
                {
                    count = count + item.Value / 2;
                }
            }

            PrintResult.PrintResultGeneric(count);
        }
    }
}
