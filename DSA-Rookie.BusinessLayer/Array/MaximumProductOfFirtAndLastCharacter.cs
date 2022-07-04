using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Array
{
    public class MaximumProductOfFirtAndLastCharacter
    {
        public static void CalculateMaximumProduct(string str)
        {
            /* Input: 12345 -> Output: 5*4=20
            Convert string to int[] - Parse string value to int to convert char to int
            Multiple only [0] and [LastIndex]
            Shift index of arrays after each multiplication.
            Create variable to hold value of 1st index as loop is anticlockwise
            Create variable to hold multiplied value            
            */

            // Converting string to int array for array manipulation
            int[] convertedArray = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                int intValue;
                int.TryParse(str[i].ToString(), out intValue);
                convertedArray[i] = intValue;
            }

            int maxValue = 0;
            // 1st loop required to calculate first and last index after each complete rotation 
            for (int j = 0; j < str.Length; j++)
            {
                // 2nd loop multiplies first and last index and then shift values to previous index 
                int firstValue = 0;
                for (int i = 0; i < convertedArray.Length; i++)
                {
                    if (i == 0)
                    {
                        firstValue = convertedArray[i];
                        int currentValue = convertedArray[0] * convertedArray[convertedArray.Length - 1];
                        if (maxValue < currentValue)
                        {
                            maxValue = currentValue;
                        }
                    }

                    if (i == convertedArray.Length - 1)
                    {
                        convertedArray[i] = firstValue;
                    }
                    else
                    {
                        convertedArray[i] = convertedArray[i + 1];
                    }
                }
            }

            Console.WriteLine("Maximum Product Of Firt And Last Character: " + maxValue);
            Console.ReadKey();
        }
    }
}
