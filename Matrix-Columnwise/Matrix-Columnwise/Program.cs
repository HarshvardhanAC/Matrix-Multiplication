/*
 Author :- Harsh Vardahn Acharya
 Date - 04-03-2024 
 Project Description :- The project is to print the matrix column wise and the nearest values present in the matrix.
 User will input rows and columns and matrix will print column wise.  
 Then user will input the value present in the matrix and only nearest values will be displayed  
 
  */

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Columnwise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rows and columns :");


            try
            {


                Console.WriteLine("Enter the rows.");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the columns.");
                int column = Convert.ToInt32(Console.ReadLine());

                int[,] matrix = new int[row, column];

                Console.WriteLine(" Reading Values from user ");

                for (int i = 0; i < row; i++)
                {
                    Console.WriteLine("Enter the values for column " + i);
                    for (int j = 0; j < column; j++)
                    {
                        matrix[j, i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Printing the  Matrix");

                for (int i = 0; i < row; i++)
                {

                    for (int j = 0; j < column; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Enter one of the value present in matrix");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < row; i++)
                {

                    for (int j = 0; j < column; j++)
                    {
                        if (matrix[i, j] == num)
                        {
                            if (i == 0 && j == 0)
                            {
                                j++;
                                Console.WriteLine("Nearest right value " + matrix[i, j]);
                                j--;
                                i++;
                                Console.WriteLine("Nearet bottom value " + matrix[i, j]);
                            }
                            else if (i >= 1 && j == 0)
                            {
                                i--;
                                Console.WriteLine("Nearest Top value " + matrix[i, j]);
                                i++;
                                j++;
                                Console.WriteLine("Nearest right value " + matrix[i, j]);
                                j--;

                                int k = i;
                                k++;
                                if (k < row && k - i == 1)
                                {
                                    i++;
                                    Console.WriteLine("Nearest bottom value " + matrix[i, j]);
                                }

                            }
                            else if (j == (column - 1) && i == 0)
                            {
                                j--;
                                Console.WriteLine("Nearest left value" + matrix[i, j]);
                                j++;
                                i++;
                                Console.WriteLine("Nearest bottom value " + matrix[i, j]);
                            }
                            else if (j == (column - 1) && i >= 1)
                            {
                                i--;
                                Console.WriteLine("Nearest Top value " + matrix[i, j]);
                                i++;
                                j--;
                                Console.WriteLine("Nearest left value" + matrix[i, j]);

                                int k = 0;
                                k++;

                                if (k < row && k - i == 1)
                                {
                                    j++;
                                    i++;
                                    Console.WriteLine("Nearest bottom value " + matrix[i, j]);
                                }
                            }
                            else
                            {
                                if ((i == 0 && j >= 1))
                                {
                                    j++;
                                    Console.WriteLine("Nearest right value" + matrix[i, j]);
                                    j = j - 2;
                                    Console.WriteLine("Nearest left value" + matrix[i, j]);
                                    j++;
                                    i++;
                                    Console.WriteLine("Nearest Bottom Value" + matrix[i, j]);

                                }
                                else
                                {
                                    if (i >= 1 && j >= 1)
                                    {
                                        i--;
                                        Console.WriteLine("Nearest Top value " + matrix[i, j]);
                                        i++;
                                        j--;
                                        Console.WriteLine("Nearest left value " + matrix[i, j]);
                                        j = j + 2;
                                        Console.WriteLine("Nearest right value " + matrix[i, j]);

                                        int k = i;
                                        k++;

                                        if (k < row && k - i == 1)                        //(n - (2 * i - 1) == 1)
                                        {
                                            i++;
                                            j--;
                                            Console.WriteLine("Nearest bottom value " + matrix[i, j]);
                                        }

                                    }
                                }
                            }

                        }
                        else
                        {

                        }
                    }
                    Console.WriteLine();
                }


            }
            catch 
            {
                Console.WriteLine("Invalid user input.Please enter valid positive integer only ");
            } 
            



        }
    }
}
