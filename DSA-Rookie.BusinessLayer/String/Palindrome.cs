using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class Palindrome
    {
        public static void CheckPalindrome(string stringParam)
        {
            /* Palindrome is a condition in which reverse of a string is same as original string.
             * Input: ABCDCBA -> Output: Palindrome
             * Input: AAAAA -> Output: Palindrome
             * Input: geeks -> Output: Not Palindrome
             */

            #region Naive Method
            StringBuilder anotherString = new StringBuilder();
            for (int i = stringParam.Length - 1; i >= 0; i--)
            {
                anotherString.Append(stringParam[i]);
            }

            if (stringParam.Equals(anotherString.ToString()))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

            #endregion

            #region Optimized

            int start = 0;
            int end = stringParam.Length - 1;
            bool isPalindrome = true;
            while (start < end)
            {
                if(stringParam[start] != stringParam[end])
                {
                    isPalindrome = false;
                    break;
                }

                start++;
                end--;
            }

            PrintResult.PrintResultGeneric("Is Palindrom: " + isPalindrome);

            #endregion
        }
    }
}
