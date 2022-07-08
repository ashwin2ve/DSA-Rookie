using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Rookie.BusinessLayer.Pattern
{
    public class Swastik
    {
        public static void Draw(int rowsColums)
        {
            if (rowsColums % 2 == 0)
            {
                Console.WriteLine("Please enter odd number for perfect view.");
            }
            else
            {
                int rows = rowsColums, columns = rowsColums, mid = (rowsColums / 2) + 1;
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= columns; j++)
                    {
                        if (i == 1)
                        {
                            if (j == 1 || j >= mid)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }

                        }

                        if (i > 1 && i < mid)
                        {
                            if (j == 1 || j == mid)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }

                        if (i == mid)
                        {
                            Console.Write("*");
                        }

                        if (i > mid && i < rows)
                        {
                            if (j == mid || j == columns)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }

                        if (i == rows)
                        {
                            if ((j >= 1 && j <= mid) || j == columns)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
