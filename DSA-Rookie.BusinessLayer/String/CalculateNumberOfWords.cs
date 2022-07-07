using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DSA_Rookie.BusinessLayer.String
{
    public class CalculateNumberOfWords
    {
        public static void Convert(string s)
        {
            /*
            Input : saveChangesInTheEditor             
            Output : 5

            Explanation: String  contains five words: 
                         
             save
             Changes
             In
             The
             Editor

            Input: oneTwoThree
            Output: 3
             */

            int number = 1;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 65 && s[i] <= 90)
                {
                    number = number + 1;
                }
            }

            PrintResult.PrintResultGeneric(number);
        }
    }
}
