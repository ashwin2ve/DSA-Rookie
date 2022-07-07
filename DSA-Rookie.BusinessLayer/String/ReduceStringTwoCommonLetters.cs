using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class ReduceStringTwoCommonLetters
    {
        public static void ReduceString(string s)
        {
            /* Input : aaabccddd -> Output: abd
             * Input : mwkommokwmxjivkkvijxshscbbcshsgwdyqqydwgzpnlzzlnpzvfeaiiaefvyeqjccjqeymhqhiihqhmhaomkkmoahhddymmyddh -> Output : Empty string
             URL : https://www.hackerrank.com/challenges/reduced-string/problem?isFullScreen=true
             */
            StringBuilder strTemp = new StringBuilder();
            StringBuilder str = new StringBuilder();
            strTemp.Append(s);
            str.Append(s);

            do
            {
                var tempString = str.ToString();
                for (int i = 1; i < tempString.Length; i++)
                {
                    if (tempString[i] == tempString[i - 1])
                    {
                        string stringToRemove = string.Format("{0}{0}", tempString[i]);
                        str.Replace(stringToRemove, "");
                    }
                }

                if (tempString.Equals(str.ToString()))
                {
                    break;
                }
            }
            while (!str.Equals(strTemp));

            PrintResult.PrintResultGeneric(string.IsNullOrEmpty(str.ToString()) ? "String Empty" : str.ToString());
        }
    }
}
