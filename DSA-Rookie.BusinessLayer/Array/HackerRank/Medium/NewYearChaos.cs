using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class NewYearChaos
    {
        public static void Print(List<int> q)
        {
            /* URL : https://www.hackerrank.com/challenges/new-year-chaos/problem
             * Input: 5, 1, 2, 3, 7, 8, 6, 4 ; Output: Too chaotic
             * Input: 1, 2, 5, 3, 7, 8, 6, 4 ; Output: 7
             * Input: 2, 1, 5, 3, 4 ; Output: 3
             * Input: 2, 5, 1, 3, 4 ; Output: Too chaotic
             */
            int count = 0;
            bool isChaotic = false;
            for(int i = q.Count -1; i >= 0; i--)
            {
                if(q[i] != i + 1)
                {
                    if (i >= 0 && q[i - 1] == i + 1)
                    {
                        var temp = q[i];
                        q[i] = q[i - 1];
                        q[i - 1] = temp;
                        count++;
                    }
                    else if (i >= 0 && q[i - 2] == i + 1)
                    {
                        var temp = q[i-1];
                        q[i - 1] = q[i -2];
                        q[i - 2] = temp;

                        temp = q[i];
                        q[i] = q[i - 1];
                        q[i - 1] = temp;

                        count += 2;
                    }
                    else
                    {
                        isChaotic = true;
                        break;
                    }
                }
            }            


            if(!isChaotic)
            {
                PrintResult.PrintResultGeneric(count);
            }
            else
            {
                PrintResult.PrintResultGeneric("Too chaotic");
            }
        }
    }
}
