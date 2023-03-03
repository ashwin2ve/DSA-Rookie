using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Algorithms
{
    public class MarkAndToys
    {
        public static void Calculate(List<int> prices, int k)
        {
            /* URL : https://www.hackerrank.com/challenges/mark-and-toys/problem
             * Input:   7 50 (7 = Number of elements, k = 50)
                        1 12 5 111 200 1000 10 (List)
               Output:  4

               Input: N = 10, K =  50
                   cost = { 1, 12, 5, 111, 200, 1000, 10, 9, 12, 15 }
               Output: 6

                Input: N = 7, K = 50
                       cost = { 1, 12, 5, 111, 200, 1000, 10 }
                Output: 4               
             * 
             */

            prices.Sort();
            int count = 0;
            int price = 0;
            for(int i = 0; i < prices.Count; i++)
            {
                if(price <= k)
                {
                    price = price + prices[i];
                    if (price <= k)
                    {
                        count++;
                    }
                }
                else
                {
                    break;
                }
            }

            count.Print();
        }
    }
}
