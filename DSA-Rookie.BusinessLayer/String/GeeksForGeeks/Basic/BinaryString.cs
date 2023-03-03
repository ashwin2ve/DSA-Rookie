using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class BinaryString
    {
        /*Input: N = 4  S = 1111
          Output: 6
          Explanation: There are 6 substrings from the given string. They are 11, 11, 11, 111, 111, 1111.

          Input: N = 5 S = 01101
          Output: 3
          Explanation: There 3 substrings from the given string. They are 11, 101, 1101.   

          Input: N=84 S = 011110011010110000010110001111000111010111101001010100100011101010111010101001010000
          Output: 861
          Input: N=29 S = 01110010101010011001000111001
          Output: 78
          URL : https://practice.geeksforgeeks.org/problems/binary-string-1587115620/0/?track=DSASP-Strings&batchId=154
                https://www.geeksforgeeks.org/given-binary-string-count-number-substrings-start-end-1/
        */

        #region Naive Method
        public static long TotalBinaryString(int n, string a)
        {
            //n is length of string, a is string
            /* First value 1 index and last value 1 index.
             * 
             */

            if (a == "0")
            {
                return 0;
            }

            int count = 0;
            int right = n-1;

            while (true)
            {
                if (a[right] == '1')
                {
                    break;
                }

                right--;
            }

            for (int left = 0; left < right; left++)
            {
                if (a[left] == '1')
                {
                    //leftIndex = left;
                    for (int i = left + 1; i <= right; i++)
                    {
                        if (a[i] == '1')
                        {
                            count++;
                        }
                    }                    
                }
            }

            return count;
        }

        #endregion

        #region Optimized
        /* Formula used : n * n-1 / 2
         */
        public static long TotalBinaryStringOptimized(int n, string a)
        {
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                if(a[i] == '1')
                {
                    count++;
                }
            }

            var value = count * (count - 1) / 2;

            return value;
        }

        #endregion
    }
}
