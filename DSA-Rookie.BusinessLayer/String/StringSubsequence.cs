using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class StringSubsequence
    {
        public static void CheckSubStringIsSubSequence(string stringParam, string subString)
        {
            /* Input: S1: GEEKSFORGEEKS S2: GRGES -> Output:True
             */
            int stringParamIndex = 0;
            int subStringIndex = 0;
            while (stringParamIndex < stringParam.Length && subStringIndex < subString.Length)
            {
                if (stringParam[stringParamIndex] == subString[subStringIndex])
                {
                    stringParamIndex++;
                    subStringIndex++;
                }
                else
                {
                    stringParamIndex++;
                }
            }

            if (subStringIndex > subString.Length - 1)
            {
                PrintResult.PrintResultGeneric("substring is subsequence of stringParam.");
            }
            else
            {
                PrintResult.PrintResultGeneric("Not a subsequence");
            }
        }
    }
}
