using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer
{
    public static class PrintResult
    {
        public static void PrintArrayResult(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }

        public static void PrintCharArrayResult(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }

        public static void PrintResultGeneric<T>(T value)
        {
            Console.Write(value);
            Console.ReadKey();
        }

        public static void PrintArrayListResult(ArrayList arr)
        {            
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }

        public static void PrintListResult<T>(List<T> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
