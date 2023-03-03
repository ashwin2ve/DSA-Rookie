using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class ArrayLeftRotation
    {
        public static List<int> Print(List<int> a, int d)
        {
            /* a = { 1, 2, 1, 2, 1, 3, 2 }, d = 3 -> Output: {2,1,3,2,1,2,1 }
             */
            d = d % a.Count;
            int count = 0;
            while (count < d)
            {
                int temp = 0;
                for (int i = 0; i < a.Count; i++)
                {
                    if (i == 0)
                    {
                        temp = a[i];
                        a[i] = a[i + 1];
                    }
                    else if (i == a.Count - 1)
                    {
                        a[i] = temp;
                    }
                    else
                    {
                        a[i] = a[i + 1];
                    }
                }

                count++;
            }

            return a;
        }

        public static void OptimizedPrint(List<int> a, int d)
        {            
            d = d % a.Count;
            Swap(a, 0, d - 1);
            Swap(a, d, a.Count - 1);
            Swap(a, 0, a.Count - 1);

            PrintResult.PrintListResult(a);
        }

        private static void Swap(List<int> a, int left, int right)
        {
            while(left < right)
            {
                var temp = a[left];
                a[left] = a[right];
                a[right] = temp;
                left++;
                right--;
            }
        }
    }
}
