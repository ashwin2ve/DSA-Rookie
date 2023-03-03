using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class FindUniqueArrayElement
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            // {9, 3, 9, 3, 9, 7, 9 }
            bool isUnique = true;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (i != j && A[i] == A[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    return A[i];
                }
            }

            return 0;
        }
    }

}
