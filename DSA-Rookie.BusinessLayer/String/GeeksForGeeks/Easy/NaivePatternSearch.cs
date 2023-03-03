using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class NaivePatternSearch
    {
        /* Input: S = aabaacaadaabaaabaa  P = aaba
           Output: Yes
           Explanation: Given pattern aaba is found in the string at index 0.

            Input: S = aabaacaadaabaaabaa P = ccda
            Output: No
            Explanation: Given pattern ccda doesn't exists in the string at all.
         */
        public static bool Search(string pat, string txt)
        {
            bool isPatterFound = false;

            char[] patArray = pat.ToCharArray();
            char[] txtArray = txt.ToCharArray();
            int patArrayIndex = 0;

            for (int i = 0; i < txtArray.Length; i++) 
            {                
                if (patArray[patArrayIndex] == txtArray[i])
                {
                    patArrayIndex++;
                }
                else if(patArrayIndex != 0)
                {
                    patArrayIndex = 0;
                    i--;
                }                

                if (patArrayIndex > patArray.Length - 1)
                {
                    isPatterFound = true;
                    break;
                }
            }

            return isPatterFound;
        }
    }
}
