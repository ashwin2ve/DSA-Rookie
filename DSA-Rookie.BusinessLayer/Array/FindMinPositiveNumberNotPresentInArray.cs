using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public  class FindMinPositiveNumberNotPresentInArray
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int count = 1;
            A = A.Sort(0, A.Length);
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == count)
                {
                    count = A[i] + 1;
                }
            }

            return count;
        }        
    }
}
