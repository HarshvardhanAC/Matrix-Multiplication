/*
 Author :- Harsh Vardhan Acharya
 Date :- 4-03-2024
 Project Description :- The project is about calculating the matrix addition of 2 matrices.
 User Will input values for both the matrices and result will be of new matrix of addition.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Rows and Columns for matrix 1 ");
            Console.WriteLine();

            try
            {


                Console.WriteLine("Enter the Rows :- ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Columns :- ");
                int Column = Convert.ToInt32(Console.ReadLine());

                int[,] matrix1 = new int[row, Column];

                Console.WriteLine();

                Console.WriteLine("The Matrix will be of " + row + "x" + Column);

                Console.WriteLine();

                Console.WriteLine("Reading values from user");

                for (int i = 0; i < row; i++)
                {
                    Console.WriteLine("Enter the values in row " + i);

                    for (int j = 0; j < Column; j++)
                    {
                        matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }



                Console.WriteLine("Printing the Matrix");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < Column; j++)
                    {
                        Console.Write(matrix1[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                Console.WriteLine("Enter the Rows and Columns for matrix 2 ");

                int rows = Convert.ToInt32(Console.ReadLine());
                int columns = Convert.ToInt32(Console.ReadLine());

                int[,] matrix2 = new int[row, columns];

                Console.WriteLine();

                Console.WriteLine("The Matrix will be of " + rows + "x" + columns);

                Console.WriteLine();

                Console.WriteLine("Reading values from user");



                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine("Enter the values in row " + i);

                    for (int j = 0; j < columns; j++)
                    {
                        matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Printing the Matrix");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(matrix2[i, j] + " ");
                    }
                    Console.WriteLine();
                }


                Console.WriteLine();

                Console.WriteLine("Matrix Addition for Matrix 1 and Matrix 2 ");

                int[,] Add = new int[row, columns];

                for (int i = 0; i < row; i++)
                {

                    for (int j = 0; j < columns; j++)
                    {
                        Add[i, j] = 0;
                        Add[i, j] = Add[i, j] + matrix1[i, j] + matrix2[i, j];

                    }
                }

                Console.WriteLine("Printing the matrix addition");

                for (int i = 0; i < row; i++)
                {

                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(Add[i, j] + " ");

                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("Entered the wrong input.Please enter the valid positive integer value  ");            
            }














        }
    }
}
