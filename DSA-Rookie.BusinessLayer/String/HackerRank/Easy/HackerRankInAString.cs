using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class HackerRankInAString
    {
        public static void Check(string s)
        {
            /* Input: hereiamstackerrank -> Output: Yes
             * Input: hackerworld -> Output: No
             * Input: hhaacckkekraraannk -> Output: Yes
             * Input: rhbaasdndfsdskgbfefdbrsdfhuyatrjtcrtyytktjjt -> Output: No
             * URL : https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem
             */

            string hackerRank = "hackerrank";

            int j = 0;
            for(int i = 0; i < s.Length; i++) 
            {
                if(s[i] == hackerRank[j])
                {
                    j++;
                }
            }

            if(j != hackerRank.Length)
            {
                PrintResult.PrintResultGeneric("NO");
            }
            else
            {
                PrintResult.PrintResultGeneric("YES");
            }
        }
    }
}
