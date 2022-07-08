using System;
using DSA_Rookie.BusinessLayer.Array;
using DSA_Rookie.BusinessLayer.Pattern;
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

        private const string StringSample5 = "GEEKSFORGEEKS";

        private const string StringSample6 = "GRGEIS";

        private readonly string[] StringSubArray = {"abcde", "bc"};

        private readonly string StringSample7 = "aaabccddd";

        private readonly string StringSample8 = "2bb#A";

        private readonly string StringSample9 = "oneTwoThree";
        #endregion

        #region Integer

        private readonly int[] IntArraySample1 = { 30, 20, 10 };

        private readonly int[] IntArraySample2 = { 6, -2, -3, 4, -1, -2, 1, 5, -3 };

        private readonly int[] IntArraySample3 = { 3, 1, 4, 4, 5, 2, 6, 1 };

        private readonly int[] IntArraySample4 = { -1, 3, -5, 6, 3, 6, -7, -4, -9, 10 };

        private readonly int[] IntArraySample5 = { 5, 8, 9 };

        private readonly int[] IntArraySample6 = { 4, 7, 8 };

        private const int NumberSample1 = 121251;

        private const int NumberSample2 = 2;

        #endregion

        #endregion

        static void Main(string[] args)
        {
            Program obj = new Program();
            //int num = Console.Read() - '0';
            int num = 3;
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

                case 3:
                    Console.WriteLine("Pattern Programs");
                    obj.PatternProgram();
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

            //MergeSortedArray.MergeSortedArrays(IntArraySample5, IntArraySample6);
        }        

        public void StringPrograms()
        {
            //Not complete
            //EncloseSubstringInParenthesis.EncloseSubstringIn(StringSample4, StringSubArray);

            //ReverseAString.ReverseString(StringSample3);

            //FindMatchPatternIndex.FindIndexIfPatterMatch(StringSample5, StringSample6);

            //Palindrome.CheckPalindrome(StringSample6);

            //StringSubsequence.CheckSubStringIsSubSequence(StringSample5, StringSample6);

            //LeftmostRepeatingCharacter.Find(StringSample5);

            //LeftmostNonRepeatingCharacter.Find(StringSample5);

            //ReduceStringTwoCommonLetters.ReduceString(StringSample7);

            //CalculateNumberOfWords.Convert(StringSample9);

            //CheckPasswordIfStrong.Check(StringSample8.Length, StringSample8);

        }

        public void PatternProgram()
        {
            //SolidAndHollowRectangle.Draw(7, 5);

            //StarPattern.Draw(5);
            
            //Swastik.Draw(23);

        }
    }

    
}
