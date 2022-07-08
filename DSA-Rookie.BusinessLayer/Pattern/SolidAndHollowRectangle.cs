using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Pattern
{
    public class SolidAndHollowRectangle
    {
        public static void Draw(int column, int rows)
        {
            for (int i = 0; i < rows; i++) 
            {
                for(int j = 0; j < column; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i > 0 && i < rows - 1) 
                    {
                        if(j == 0 || j == column - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
