using System;
using DSA_Rookie.BusinessLayer.Array;

namespace DSA_Rookie.App
{
    class Program
    {
        #region Private Members

        private const string StringSample1 = "12345";

        private const string StringSample2 = "86591";
        
        private readonly int[] IntArraySample1 = new int[] { 3, 2, 1 };

        private readonly int[] IntArraySample2 = new int[] { 6, -2, -3, 4, -1, -2, 1, 5, -3 };

        private readonly int[] IntArraySample3 = { 12, 10, 5, 6, 52, 36 };

        private readonly int[] IntArraySample4 = { -1, 3, -5, 6, 3, 6, -7, -4, -9, 10 };

        private readonly int[] IntArraySample5 = { 4, 4, 4, 4, 4 };

        private const int NumberSample1 = 121251;

        private const int NumberSample2 = 2;

        #endregion

        static void Main(string[] args)
        {
            Program obj = new Program();
            //int num = Console.Read() - '0';
            int num = 1;
            switch (num)
            {
                case 1:
                    Console.WriteLine("Array Programs");
                    obj.ArrayPrograms();
                    break;

                default:
                    Console.WriteLine("Not Available");
                    break;
            }
        }

        public void ArrayPrograms()
        {
            //MaximumProductOfFirtAndLastCharacter maximumProductOfFirtAndLastCharacter = new MaximumProductOfFirtAndLastCharacter();
            //maximumProductOfFirtAndLastCharacter.CalculateMaximumProduct(StringSample2);

            //SplitArrayAndAddToEnd splitArrayAndAddToEnd = new SplitArrayAndAddToEnd();
            //splitArrayAndAddToEnd.SplitArrayAndAddFirstPartToEnd(IntArraySample3, NumberSample2);

            //PositiveElementsAtEvenAndNegativeAtOdd positiveElementsAtEvenAndNegativeAtOdd = new PositiveElementsAtEvenAndNegativeAtOdd();
            //positiveElementsAtEvenAndNegativeAtOdd.SortPositiveNegativeElementsAtEvenOdd(IntArraySample4);

            //MaximumSumAlongAllRotationOfArray maximumSumAlongAllRotationOfArray = new MaximumSumAlongAllRotationOfArray();
            //maximumSumAlongAllRotationOfArray.MaximumSumAlongAllRotation(IntArraySample1);

            MeanAndMedianUnsorted meanAndMedianUnsorted = new MeanAndMedianUnsorted();
            meanAndMedianUnsorted.CalculateMeanAndMedian(IntArraySample5);
        }
    }
}
