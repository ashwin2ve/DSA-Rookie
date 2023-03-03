using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class CountingValleys
    {
        public static void Print(string str)
        {
            /* URL : https://www.hackerrank.com/challenges/counting-valleys/problem
             * Input: UDDDUDUU ; Output: 1
             * Input: DDUUDDUDUUUD ; Output: 2
             */
            int count = 0;
            int valleyCount = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == 'U' && count == -1)
                {
                    valleyCount++;
                }

                if(str[i] == 'D')
                {
                    count--;
                }
                else if(str[i] == 'U')
                {
                    count++;
                }                
            }

            PrintResult.PrintResultGeneric(valleyCount);
        }
    }
}
