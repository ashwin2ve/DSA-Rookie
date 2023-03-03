using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public static class CreateWordWithJumbledLetters
    {
        public static void Create(string str)
        {
            // Create a valid word from a jumbled string. All lowercase letters
            // Input: warad -> Output: award;
            // Input: eth -> Output: the
            // Input: fiel -> Output: life

            Dictionary<string, string> filteredListDictionary = new Dictionary<string, string>();
            

            ArrayList arrayList = new ArrayList();
            arrayList.Add("the");
            arrayList.Add("best");
            arrayList.Add("award");
            arrayList.Add("life");

            for (int index = 0; index < arrayList.Count; index++)
            {
                if (arrayList[index].ToString().Length == str.Length)
                {
                    var sortedListItem = SortedItem(arrayList[index].ToString());
                    filteredListDictionary.Add(sortedListItem, arrayList[index].ToString());
                }
            }

            var sortedString = SortedItem(str);
            foreach (var listItem in filteredListDictionary)
            {
                if (sortedString == listItem.Key)
                {
                    PrintResult.PrintResultGeneric(listItem.Value);
                }
            }
        }

        private static string SortedItem(string str)
        {
            char[] strArr = str.ToCharArray();
            while (true)
            {
                var tempArray = new string(strArr);
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (strArr[i] > strArr[i + 1])
                    {
                        var temp = strArr[i];
                        strArr[i] = strArr[i + 1];
                        strArr[i + 1] = temp;
                    }
                }

                if (tempArray.Equals(new string(strArr)))
                {
                    break;
                }
            }

            return new string(strArr);
        }
    }
}
