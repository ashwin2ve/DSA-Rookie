using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class LeftmostRepeatingCharacter
    {
        public static void Find(string str)
        {
            /* Input  : geeksforgeeks
               Output : g
               (mind that it will be g, not e.)
               
               Input  : abcdabcd
               Output : a
               
               Input  : abcd
               Output : -1
               No character repeats
             URL : https://www.geeksforgeeks.org/repeated-character-whose-first-appearance-is-leftmost/
             */

            dynamic index = null;
            ArrayList arrayList = new ArrayList();
            
            for (int i = str.Length - 1; i >= 0; i--) 
            {
                if (arrayList.Contains(str[i])){
                    index = str[i];
                }
                else
                {
                    arrayList.Add(str[i]);
                    index = -1;
                }
            }

            PrintResult.PrintResultGeneric(index);
        }
    }
}
