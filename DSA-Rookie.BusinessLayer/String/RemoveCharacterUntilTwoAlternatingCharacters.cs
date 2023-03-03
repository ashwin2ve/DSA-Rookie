using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class RemoveCharacterUntilTwoAlternatingCharacters
    {
        public static void Calculate(string str)
        {
            /*Given a string, remove characters until the string is made up of any two alternating characters. 
              When you choose a character to remove, all instances of that character must be removed. 
              Determine the longest string possible that contains just two alternating letters.
             
            Example : Input : abaacdabd ->Output 4 (bdbd)
                      Delete a, to leave bcdbd. Now, remove the character c to leave the valid string bdbd with a length of 4. 
                      Removing either b or d at any point would not result in a valid string. Return 0.
                      Given a string , convert it to the longest possible string  made up only of alternating characters. 
                      Return the length of string . If no string  can be formed, return .
            Input: asvkugfiugsalddlasguifgukvsa -> Output:0
            Input: asdcbsdcagfsdbgdfanfghbsfdab -> Output: 8
            Input: beabeefeab -> Output: 5 (babab)
            Input: ab -> Output: 2
            Input: txnbvnzdvasknhlmcpkbxdvofimsvqbvkswlkrchohwuplfujvlwpxtlcixpajjpaskrnjneelqdbxtiyeianqjqaikbukpicrwpnjvfpzolcredzmfaznnzd -> Output:6 (hohoho)
            URL : https://www.hackerrank.com/challenges/two-characters/problem?isFullScreen=true&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
             */

            string longestString = string.Empty;
            if (str.Length == 2)
            {
                longestString = str;
                PrintResult.PrintResultGeneric(str.Length);
                //can be returned from here directly.
            }

            // Added the characters present in the string in distinct order
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (!stringBuilder.ToString().Contains(str[i]))
                {
                    stringBuilder.Append(str[i]);
                }
            }

            // As the final string can be made up of two alternating characters, so I retrieved the possible pairs below.
            ArrayList arrayList = new ArrayList();
            for(int i = 0; i < stringBuilder.Length; i++)
            {
                for(int j = 0; j < stringBuilder.Length; j++)
                {
                    if(stringBuilder[i].ToString() != stringBuilder[j].ToString())
                    {
                        var characterPair = stringBuilder[i].ToString() + stringBuilder[j].ToString();
                        var swappedPair = GetSwappedPair(characterPair);
                        if (!arrayList.Contains(characterPair) && !arrayList.Contains(swappedPair))
                        {
                            arrayList.Add(characterPair);
                        }
                    }
                }
            }
                        
            int num = 0;
            while (num < arrayList.Count)
            {
                var value = arrayList[num].ToString();
                var charactersToRemove = str.Replace(value[0].ToString(), "");
                charactersToRemove = charactersToRemove.Replace(value[1].ToString(), "");
                stringBuilder.Clear();
                stringBuilder.Append(str);
                for (int i = 0; i < charactersToRemove.Length; i++)
                {
                    stringBuilder.Replace(charactersToRemove[i].ToString(), "");
                    if (IsMatchAlternateCharacters(stringBuilder.ToString()))
                    {
                        if (longestString.Length < stringBuilder.ToString().Length)
                        {
                            longestString = stringBuilder.ToString();
                        }
                    }
                }

                num++;
            }
            
            PrintResult.PrintResultGeneric(longestString.Length);
        }

        private static bool IsMatchAlternateCharacters(string str)
        {
            if(str.Length <= 2)
            {
                return false;
            }

            for(int i = 0; i < str.Length; i++)
            {
                if (i < str.Length - 2 && ((str[i] != str[i + 2]) || str[i] == str[i + 1]))
                {
                    return false;
                }
            }
            

            return true;
        }

        private static string GetSwappedPair(string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            var temp = sb[0];
            sb[0] = sb[1];
            sb[1] = temp;

            return sb.ToString();
        }
    }
}
