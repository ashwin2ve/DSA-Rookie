using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class MakingAnagrams
    {
        public static void Calculate(string a, string b)
        {
            /* URL : https://www.hackerrank.com/challenges/ctci-making-anagrams/problem
             * Input: a=cde ; b=abc -> Output: 4 (abde)         
             * I: showman, woman -> O: 2
             * I: fcrxzwscanmligyxyvym, jxwtrhvujlmrpdoqbisbwhmgpmeoke -> O: 30
             */

            a = a.ToLower();
            b = b.ToLower();
            Dictionary<char, int> keyValuePairsA = new Dictionary<char, int>();
            for(int i = 0; i < a.Length; i++)
            {
                if (!keyValuePairsA.ContainsKey(a[i]))
                {
                    keyValuePairsA.Add(a[i], 1);
                }
                else
                {
                    keyValuePairsA[a[i]]++;
                }
            }

            Dictionary<char, int> keyValuePairsB = new Dictionary<char, int>();
            for(int i = 0; i < b.Length; i++)
            {
                if (!keyValuePairsB.ContainsKey(b[i]))
                {
                    keyValuePairsB.Add(b[i], 1);
                }
                else
                {
                    keyValuePairsB[b[i]]++;
                }
            }

            int count = 0;

            // (Another way to set ab : Sort both string. Take minimum char and maximum char from the string.
            for (char ab = 'a'; ab <= 'z'; ab++)
            {
                if (keyValuePairsA.ContainsKey(ab) && keyValuePairsB.ContainsKey(ab))
                {
                    count += Math.Abs(keyValuePairsA[ab] - keyValuePairsB[ab]);
                }
                else if (keyValuePairsA.ContainsKey(ab))
                {
                    count += keyValuePairsA[ab];
                }
                else if (keyValuePairsB.ContainsKey(ab))
                {
                    count += keyValuePairsB[ab];
                }
            }

            count.Print();
        }
    }
}
