using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class EncloseSubstringInParenthesis
    {
        public static void EncloseSubstringIn(string str, string[] subStr)
        {
            /*
             Input: S = “abcdefgh”, subs = {“ef”, “bc”, “g”}
             Output: “a(bc)d(efg)h”
             Explanation: Substrings “ef” and “g” are consecutive. 
             So they are enclosed within one set of parentheses.
             Substring “bc” is enclosed within one set of parentheses
             
             Input: S = “abcdefgh”, subs = [“abcde”, “bc”]
             Output: “(abcde)fgh”
             Explanation: Substrings “abcde” and “bc” overlap. 
             So they are enclosed within one set of parentheses.

             URL : https://www.geeksforgeeks.org/enclose-given-substrings-of-the-string-in-parenthesis/
            */
            
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            for (int j = 0; j < subStr.Length; j++)
            {
                int subStrLength = subStr[j].Length;
                for (int i = 0; i < sb.Length; i++)
                {
                    if (i < str.Length- subStrLength && str.Substring(i, subStrLength) == subStr[j])
                    {
                        sb.Replace(subStr[j], "(" + subStr[j] + ")");                        
                    }
                }
            }

            sb.Replace(")(", "");
            PrintResult.PrintStringResult(sb.ToString());
        }
    }
}
