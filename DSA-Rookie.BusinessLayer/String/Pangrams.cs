using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class Pangrams
    {
        public static void Check(string s)
        {
            /* Input : We promptly judged antique ivory buckles for the next prize -> Output: pangram
             * Input : We promptly judged antique ivory buckles for the prize -> Output: not pangram
             * URL : https://www.hackerrank.com/challenges/pangrams/problem
             */

            ArrayList arrayList = new ArrayList();
            bool isPangram = false;
            for(int i = 0; i < s.Length; i++)
            {
                if ((s[i] > 65 && s[i] < 91) || (s[i] > 96 && s[i] < 123))
                {
                    if (!arrayList.Contains(s[i].ToString().ToLower()))
                    {
                        arrayList.Add(s[i].ToString().ToLower());
                    }

                    if (arrayList.Count == 26)
                    {
                        isPangram = true;
                        break;
                    }
                }
            }
            
            PrintResult.PrintResultGeneric(isPangram ? "pangram" : "not pangram");            
        }
    }
}
