using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer
{
    public static class MyExtensions
    {
        public static string SwapString(this string str, int left, int right)
        {
            StringBuilder stringBuilder = new StringBuilder(str);
            for(int i = left; i < right; i++)
            {
                var temp = stringBuilder[left];
                stringBuilder[left] = stringBuilder[right];
                stringBuilder[right] = temp;
            }

            return stringBuilder.ToString();
        }

        public static int[] Sort(this int[] arr, int left, int right)
        {
            while (true)
            {
                bool isProcessing = false;

                for (int i = left; i < right; i++)
                {
                    if (i > 1 && arr[i] > 0 && arr[i - 1] > 0 && arr[i] < arr[i - 1]) 
                    {
                        var temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                        isProcessing = true;
                    }
                }

                if (!isProcessing)
                {
                    break;
                }
            }

            return arr;
        }

        public static string Sort(this string str, int left, int right)
        {
            var charArray = str.ToCharArray();
            while (true)
            {
                bool isProcessing = false;

                for (int i = left; i < right; i++)
                {
                    if (charArray[i] < charArray[i - 1])
                    {
                        var temp = charArray[i];
                        charArray[i] = charArray[i - 1];
                        charArray[i - 1] = temp;
                        isProcessing = true;
                    }
                }

                if (!isProcessing)
                {
                    break;
                }
            }

            return new string(charArray);
        }

        public static int[] SelectionSort(this int[] arr, int left, int right)
        {            
            for (int i = left; i < right - 1; i++)
            {
                int? min = arr[i];
                int? index = null;
                bool isMinFound = false;
                for (int j = i + 1; j <= right - 1; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        index = j;
                        isMinFound = true;
                    }                    
                }

                if (isMinFound)
                {
                    var temp = arr[index.Value];
                    arr[index.Value] = arr[i];
                    arr[i] = temp;
                }
            }

            return arr;
        }

        public static void Print<T>(this T value)
        {
            Console.Write(value);
            Console.ReadKey();
        }

        public static void PrintResult(this ArrayList arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (i != arr.Count - 1)
                {
                    Console.Write(arr[i] + ", ");
                }
                else
                {
                    Console.Write(arr[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
