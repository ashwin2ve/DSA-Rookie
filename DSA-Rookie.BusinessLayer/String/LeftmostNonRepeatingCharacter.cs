using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class LeftmostNonRepeatingCharacter
    {
        public static void Find(string str)
        {
            /*
             * Input: "geeksforgeeks" Output:5 (index of f)
               Explanation:
               Step 1: Construct a character count array 
                       from the input string.
                  ....
                 count['e'] = 4
                 count['f'] = 1
                 count['g'] = 2
                 count['k'] = 2
                 ……
               
               Step 2: Get the first character who's 
               count is 1 ('f').
               Input: "abcabc" Output: -1
               Input: "apple" Output: 0
             * URL : https://www.geeksforgeeks.org/given-a-string-find-its-first-non-repeating-character/
             */

            dynamic character = -1;
            ArrayList arrayList = new ArrayList();
            for (int i = str.Length - 1; i >= 0; i--) 
            {
                if (!arrayList.Contains(str[i]))
                {
                    arrayList.Add(str[i]);
                    character = i;
                }
                else if(str[character] == str[i])
                {
                    character = -1;
                }
            }

            PrintResult.PrintResultGeneric(character);            
        }
    }
}
