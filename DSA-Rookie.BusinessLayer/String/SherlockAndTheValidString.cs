using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class SherlockAndTheValidString
    {
        #region Naive Solution

        public static void Check(string s)
        {
            /* Input: aabbcd Output: NO
             * Input: aabbccddeefghi Output: NO
             * Input: abcdefghhgfedecba Output:YES
             * URL: https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem
             */

            ArrayList arrayList = new ArrayList();
            for(int i = 0; i < s.Length; i++)
            {
                if (!arrayList.Contains(s[i]))
                {
                    //sb.Append(s[i]);
                    arrayList.Add(s[i]);
                }
            }

            bool isValid = IsValidString(s);
            if(!isValid)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(s);
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (arrayList[i].ToString() == s[j].ToString())
                        {
                            sb.Remove(j, 1);
                            isValid = IsValidString(sb.ToString());
                            break;
                        }
                    }

                    if (isValid)
                    {
                        break;
                    }
                }
            }
            
            PrintResult.PrintResultGeneric(isValid ? "YES" : "NO");
        }

        private static bool IsValidString(string s)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<char, int> keyValuePair = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {                
                if (!keyValuePair.ContainsKey(s[i]))
                {
                    //sb.Append(s[i]);
                    keyValuePair.Add(s[i], 1);
                }
                else
                {
                    keyValuePair[s[i]]++;
                }
            }

            int allowedValue = 0;
            foreach(var item in keyValuePair)
            {
                var value = item.Value;
                if (allowedValue == 0)
                {
                    allowedValue = value;
                }                

                if (value != allowedValue) 
                {
                    return false;
                }
            }
            
            return true;            
        }

        #endregion

        #region Optimized Solution ------ Incomplete
        public static void CheckOptimizedSolution(string s)
        {
            ArrayList arrayList = new ArrayList();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!keyValuePairs.ContainsKey(s[i]))
                {
                    keyValuePairs.Add(s[i], 1);
                }
                else
                {
                    keyValuePairs[s[i]]++;
                }
            }

            foreach(var item in keyValuePairs)
            {
                arrayList.Add(item.Value);
            }

            arrayList = SortArrayList(arrayList);

            //pairValues.Sort();
        }        

        private static ArrayList SortArrayList(ArrayList arrayList)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                var tempArrayList = arrayList;
                int temp = (int)arrayList[0];
                for (int i = 0; i < arrayList.Count - 1; i++) 
                {
                    if((int)arrayList[i] > (int)arrayList[i+1])
                    {
                        var value = (int)arrayList[i];
                        arrayList[i] = arrayList[i + 1];
                        arrayList[i + 1] = temp;
                    }
                }

                if(arrayList == tempArrayList)
                {
                    break;
                }
            }

            return arrayList;
        }

        #endregion
    }
}
