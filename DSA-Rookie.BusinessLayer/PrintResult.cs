﻿using System;
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

        public static void PrintResultGeneric<T>(T value)
        {
            Console.Write(value);
            Console.ReadKey();
        }
    }
}
