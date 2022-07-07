using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class FindMatchPatternIndex
    {
        public static void FindIndexIfPatterMatch(string str, string pattern)
        {
            for(int i = 0; i < str.Length - (str.Length - pattern.Length); i++)
            {
                if (str.Substring(i, pattern.Length) == pattern) 
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.ReadKey();            
        }
    }    
}
