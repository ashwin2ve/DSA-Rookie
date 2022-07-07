using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class ReverseAString
    {
        public static void ReverseString(string str)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(str);
            int startPos = 0;
            for (int i = 0; i < strBuilder.Length; i++)
            {
                if (str[i] == ' ')
                {
                    ReverseWord(strBuilder, startPos, i - 1);
                    startPos = i + 1;
                }
            }

            ReverseWord(strBuilder, startPos, strBuilder.Length-1);
            ReverseWord(strBuilder, 0, strBuilder.Length-1);

            PrintResult.PrintResultGeneric(strBuilder.ToString());
        }

        private static void ReverseWord(StringBuilder str, int start, int end)
        {
            while (start <= end)
            {
                var temp = str[start];
                str[start] = str[end];
                str[end] = temp;
                start++;
                end--;
            }
        }
    }
}
