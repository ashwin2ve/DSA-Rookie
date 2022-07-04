using System;
using DSA_Rookie.BusinessLayer.Array;
using DSA_Rookie.BusinessLayer.String;

namespace DSA_Rookie.App
{
    public class Program
    {
        #region Private Members

        #region String

        private const string StringSample1 = "12345";

        private const string StringSample2 = "86591";

        private const string StringSample3 = "Welcome to Yaha";

        private const string StringSample4 = "abcdefgh";

        private const string StringSample5 = "AAAAA";

        private const string StringSample6 = "AAA";

        private readonly string[] StringSubArray = {"abcde", "bc"};

        #endregion

        #region Integer

        private readonly int[] IntArraySample1 = { 30, 20, 10 };

        private readonly int[] IntArraySample2 = { 6, -2, -3, 4, -1, -2, 1, 5, -3 };

        private readonly int[] IntArraySample3 = { 3, 1, 4, 4, 5, 2, 6, 1 };

        private readonly int[] IntArraySample4 = { -1, 3, -5, 6, 3, 6, -7, -4, -9, 10 };

        private readonly int[] IntArraySample5 = { 4, 4, 4, 4, 4 };

        private const int NumberSample1 = 121251;

        private const int NumberSample2 = 2;

        #endregion

        #endregion

        static void Main(string[] args)
        {
            Program obj = new Program();
            //int num = Console.Read() - '0';
            int num = 2;
            switch (num)
            {
                case 1:
                    Console.WriteLine("Array Programs");
                    obj.ArrayPrograms();
                    break;

                case 2:
                    Console.WriteLine("String Programs");
                    obj.StringPrograms();
                    break;
                default:
                    Console.WriteLine("Not Available");
                    break;
            }
        }

        public void ArrayPrograms()
        {
            //MaximumProductOfFirtAndLastCharacter.CalculateMaximumProduct(StringSample2);

            //SplitArrayAndAddToEnd.SplitArrayAndAddFirstPartToEnd(IntArraySample3, NumberSample2);

            //PositiveElementsAtEvenAndNegativeAtOdd.SortPositiveNegativeElementsAtEvenOdd(IntArraySample4);

            //MaximumSumAlongAllRotationOfArray.MaximumSumAlongAllRotation(IntArraySample1);

            //MeanAndMedianUnsorted.CalculateMeanAndMedian(IntArraySample5);

            //Not Completed
            //FindNumbersWithMostOccurence.GetNumbersWithMostOccurence(IntArraySample3);

            //MaximumDifferenceInArray.FindMaxDifferenceInArray(IntArraySample1);

            //MaximumDifferenceInArrayJ_I.FindMaxDifferenceInArray(IntArraySample1);

            //StockBuyAndSellPossibleProfit.CalculatePossibleProfit(IntArraySample1);           
        }        

        public void StringPrograms()
        {
            //Not complete
            //EncloseSubstringInParenthesis.EncloseSubstringIn(StringSample4, StringSubArray);

            //ReverseAString.ReverseString(StringSample3);

            //FindMatchPatternIndex.FindIndexIfPatterMatch(StringSample5, StringSample6);
        }
    }

    
}
