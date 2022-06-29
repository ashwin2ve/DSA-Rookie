using System;
using DSA_Rookie.BusinessLayer.Array;

namespace DSA_Rookie.App
{
    class Program
    {
        private const string StringSample1 = "12345";

        private const string StringSample2 = "86591";
        
        private readonly int[] IntArraySample1 = new int[] { 1, 8, 8, 4, 5 };

        private readonly int[] IntArraySample2 = new int[] { 6, -2, -3, 4, -1, -2, 1, 5, -3 };

        private const int NumberSample1 = 121251;

        static void Main(string[] args)
        {
            MaximumProductOfFirtAndLastCharacter classA = new MaximumProductOfFirtAndLastCharacter();
            classA.CalculateMaximumProduct(StringSample2);
        }
    }
}
