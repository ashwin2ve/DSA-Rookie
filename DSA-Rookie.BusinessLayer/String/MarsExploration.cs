using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class MarsExploration
    {
        public static void GetErrorCount(string s)
        {
            /* Input: SOSSPSSQSSOR -> Output: 3
               Explanation:
               Expected signal: SOSSOSSOSSOS
               Recieved signal: SOSSPSSQSSOR
               Difference:          X  X   X
               
               Input: SOSSOT -> Output: 1
               Input: SOSSOSSOS -> Output: 0
            URL: https://www.hackerrank.com/challenges/mars-exploration/problem
             */

            int errorCount = 0;
            for (int i = 0; i < s.Length; i++) 
            {
                char temp;
                if (i % 3 == 0 || i % 3 == 2) 
                {
                    temp = 'S';
                }
                else
                {
                    temp = 'O';
                }

                if(temp != s[i]) 
                {
                    errorCount = errorCount + 1;
                }
            }            

            PrintResult.PrintResultGeneric(errorCount);
        }
    }
}
