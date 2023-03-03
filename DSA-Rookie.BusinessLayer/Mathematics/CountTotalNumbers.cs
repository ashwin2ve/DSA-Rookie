using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Mathematics
{
    public class CountTotalNumbers
    {
        public static void Count(int num)
        {
            /* Input: 123 -> Output:3
             * Input:123456 -> Output:6
             */
            int count = 0;
            while (num != 0)
            {
                count = count + num % 10;
                num = num / 10;
            }

            PrintResult.PrintResultGeneric(count);
        }
    }
}
