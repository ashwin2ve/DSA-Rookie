using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.String
{
    public class CheckPasswordIfStrong
    {
        public static void Check(int n, string password)
        {
            /* URL : https://www.hackerrank.com/challenges/strong-password/problem
             */
            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";
            int minimumLength = 6;

            bool isUppercaseMissing = true;
            bool isLowercaseMissing = true;
            bool isNumberMissing = true;
            bool isSpecialCharactersMissing = true;

            for (int i = 0; i < password.Length; i++)
            {
                if (numbers.Contains(password[i])){
                    isNumberMissing = false;
                }

                if (lower_case.Contains(password[i]))
                {
                    isLowercaseMissing = false;
                }

                if (upper_case.Contains(password[i]))
                {
                    isUppercaseMissing = false;
                }

                if (special_characters.Contains(password[i]))
                {
                    isSpecialCharactersMissing = false;
                }
            }

            int number = Convert.ToInt32(isNumberMissing) + Convert.ToInt32(isLowercaseMissing) + Convert.ToInt32(isUppercaseMissing) + Convert.ToInt32(isSpecialCharactersMissing);
            if (number + n >= minimumLength)
            {
                PrintResult.PrintResultGeneric(number);
            }
            else
            {
                PrintResult.PrintResultGeneric(minimumLength - n);
            }
        }
    }
}
