using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String.HackerRank.Easy
{
    public class StringConstruction
    {
        public static void Print(string str)
        {
            /* URL : https://www.hackerrank.com/challenges/string-construction/problem
             * Input: abcd -> Output: 4
             * Input: abab -> Output: 2
             */

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (!sb.ToString().Contains(str[i]))
                {
                    sb.Append(str[i]);
                }
            }

            PrintResult.PrintResultGeneric(sb.Length);

        }
    }
}
