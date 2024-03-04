/*
 Author :- HarshVardhan Acharya
 Date :- 02-03-2024
 Project Description :- Program to calculate the matrix multiplication.
 User will enter the rows and columns as well as the values for both matrices .
 Matrices should be of same size and input will be in integer values. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Enter the Rows and Columns for Matrix 1 ");

            try
            {
                Console.WriteLine("Enter the rows. ");
                int row = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Enter the columns.");
                int column = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                int[,] matrix1 = new int[row, column];

                Console.WriteLine("Reading the values for matrix " + row + "x" + column);

                for (int i = 0; i < row; i++)
                {
                    Console.WriteLine("Enter the values for row : " + i);
                    for (int j = 0; j < column; j++)
                    {
                        matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Printing Matrix 1");

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write(matrix1[i, j] + " ");
                    }
                    Console.WriteLine();
                }


                Console.WriteLine('\n');


                Console.WriteLine("Enter the Rows and Columns for Matrix 2 ");

                Console.WriteLine("Enter the rows.");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Enter the columns.");
                int columns = Convert.ToInt32(Console.ReadLine());

                int[,] matrix2 = new int[rows, columns];

                Console.WriteLine();

                Console.WriteLine("Reading the values for matrix " + rows + "x" + columns);

                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine("Enter the values for row : " + i);
                    for (int j = 0; j < columns; j++)
                    {
                        matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Printing Matrix 2");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(matrix2[i, j] + " ");
                    }
                    Console.WriteLine();
                }



                if (row == rows && column == columns)
                {
                    Console.WriteLine();

                    Console.WriteLine("Output for the Matrix Multiplication of" + row + "x" + column + " * " + rows + "x" + columns);
                    int[,] mul = new int[row, columns];

                    // int i = 0;
                    // int j = 0;

                    int k = 0;
                    // loop to increae row after successful iteration through column
                    for (int i = 0; i < row; i++)
                    {
                        int p = 0;
                        //loop to increase column after successful iteration through column
                        for (int j = 0; j < columns; j++)
                        {
                            // setting up the defalut value to 0 
                            mul[i, j] = 0;
                            //loop to iterate through every coloumn
                            for (int l = 0; l < rows; l++)
                            {
                                mul[i, j] = mul[i, j] + matrix1[k, l] * matrix2[l, p];

                            }
                            p++; //increase in p for changing column for every j
                        }
                        k++; //increae k for multiplication of next row of matrix one with matrix 2

                    }

                    Console.WriteLine("Printing output");

                    for (int i = 0; i < row; i++)
                    {

                        for (int j = 0; j < columns; j++)
                        {
                            Console.Write(mul[i, j] + " ");

                        }
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("Size of both the matrices should be same " + row + "x" + columns);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input from user. ");
            }
        }
    }
}
