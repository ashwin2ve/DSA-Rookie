using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Mathematics
{
    public class BinaryGap
    {
        public static int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Stack<int> sb = new Stack<int>();
            
            while (true)
            {
                int rem = N % 2;
                //stringBuilder.Append(rem);
                sb.Push(rem);                
                if (N <= 1)
                {
                    break;
                }

                N = N / 2;
            }

            var sbArray = sb.ToArray();
            int maxZeroCount = 0;
            int count = 0;
            for (int i = 0; i < sbArray.Length; i++)
            {
                if (sbArray[i] == 0)
                {
                    count++;
                }
                else
                {
                    if (maxZeroCount < count)
                    {
                        maxZeroCount = count;
                    }

                    count = 0;
                    //isProcess = false;
                }
            }

            return maxZeroCount;
        }
    }
}