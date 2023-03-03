using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class CaesarCipher
    {
        public static void GetEncryptedData(string s, int k)
        {
            /* Input: abcdefghijklmnopqrstuvwxyz -> Output: defghijklmnopqrstuvwxyzabc
             * Input: middle-Outz -> Output: okffng-Qwvb
             * Input: www.abc.xy -> Output: fff.jkl.gh
             * Input: Always-Look-on-the-Bright-Side-of-Life -> Output: Fqbfdx-Qttp-ts-ymj-Gwnlmy-Xnij-tk-Qnkj
             * URL : https://www.hackerrank.com/challenges/caesar-cipher-1/problem
             */

            k = k > 26 ? k % 26 : k;
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] > 64 && s[i] < 91)
                {
                    if (s[i] + k > 90) 
                    {
                        var diff = s[i] + k - 90;
                        builder.Append(Convert.ToChar(64 + diff));
                    }
                    else
                    {
                        builder.Append(Convert.ToChar(s[i] + k));
                    }
                }

                if (s[i] > 96 && s[i] < 123)
                {
                    if (s[i] + k > 122)
                    {
                        var diff = s[i] + k - 122;
                        builder.Append(Convert.ToChar(96 + diff));
                    }
                    else
                    {
                        builder.Append(Convert.ToChar(s[i] + k));
                    }
                }

                if ((s[i] < 97 && s[i] > 90) || s[i] > 122 || s[i] < 65) 
                {
                    builder.Append(s[i]);
                }

            }

            PrintResult.PrintResultGeneric(builder.ToString());
        }
    }
}
