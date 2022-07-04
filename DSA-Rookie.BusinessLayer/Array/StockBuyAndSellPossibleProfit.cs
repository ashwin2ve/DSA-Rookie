using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class StockBuyAndSellPossibleProfit
    {
        public static void CalculatePossibleProfit(int[] arr)
        {
            /* Input: {1,5,3,8,12}
             * Output: 13 ; Purchase at 1 -> Sell at 5, Purchase at 3 -> Sell at 12
              
             * Input: {30,20,10}
             * Output: 0
              
             * Input: {10,20,30}
             * Output: 20
              
             * Input: {1,5,3,1,2,8}
             * Output: 11
             */

            int buy = int.MaxValue;
            int sell = 0;
            int total = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < buy)
                {
                    buy = arr[i];
                }

                if(buy != arr[i] && arr[i] > sell)
                {
                    sell = arr[i];
                }

                if (sell > buy)
                {
                    if ((i == arr.Length - 1) || (i != arr.Length - 1 && arr[i] > arr[i + 1]))
                    {
                        total = total + (sell - buy);
                        sell = 0;
                        buy = int.MaxValue;
                    }
                }
            }

            PrintResult.PrintIntResult(total);
        }
    }
}
