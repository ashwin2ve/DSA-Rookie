using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class ElectronicsShop
    {
        public static void Calculate(int[] keyboards, int[] drives, int b)
        {
            /* URL : https://www.hackerrank.com/challenges/electronics-shop/problem
             */
            int maxValue = 0;
            for (int i = 0; i < keyboards.Length; i++)
            {
                if (keyboards[i] < b)
                {
                    for (int j = 0; j < drives.Length; j++)
                    {
                        int count = keyboards[i] + drives[j];
                        if (count <= b && maxValue < count)
                        {
                            maxValue = count;
                        }
                    }
                }
            }

            maxValue.Print();
        }
    }
}
