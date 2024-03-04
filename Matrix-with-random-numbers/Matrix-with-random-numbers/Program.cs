/*
 * Author :- Harsh Vardhan Acharya
 * Date :- 04-03-2024 
 * Project Description :- The program is to calculate the nearest values of a particular value present in the matrix.
 * User will input the rows and columns of a matrix.Computer will randomly assign values to matrix .
 * User will input one value from matrix and its nearest value will be calculated and printed.
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_with_random_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number for Rows and Columns for a matrix");

            try
            {


                Console.WriteLine("Enter the rows for matrix1");

                int row = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the columns for matrix1");

                int column = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The following matrix is of" + row + "x" + column);
                int[,] matrix = new int[row, column];

                Console.WriteLine("Values of matrix are randomly printed by computer");
                Random random = new Random();

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        matrix[i, j] = random.Next(100);
                        Console.Write(matrix[i, j] + " ");


                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Enter one of the value present in matrix");
                int num = Convert.ToInt32(Console.ReadLine());

                int rows = 3, columns = 3;
                int[,] new_matrix = new int[rows, columns];
                int a = 0, b = 0;


                for (int i = 0; i < row; i++)
                {

                    for (int j = 0; j < column; j++)
                    {
                        if (matrix[i, j] == num)
                        {
                            if (i == 0 && j == 0)
                            {
                                new_matrix[0, 0] = num;
                                j++;
                                new_matrix[0, 1] = matrix[i, j];
                                Console.WriteLine("Nearest right value -  " + matrix[i, j]);
                                j--;
                                i++;
                                new_matrix[1, 0] = matrix[i, j];
                                Console.WriteLine("Nearet bottom value -  " + matrix[i, j]);

                                j++;
                                new_matrix[1, 1] = matrix[i, j];
                                Console.WriteLine("Nearest bottom right diagonal value -  " + matrix[i, j]);


                                //storing other values as 0
                                for (a = 0; a < 2; a++)
                                {
                                    for (b = 0; b < 2; b++)
                                    {
                                        Console.Write(new_matrix[a, b] + " ");

                                    }
                                    Console.WriteLine();
                                }

                            }

                            //for column 1
                            else if (i >= 1 && j == 0)
                            {
                                //(1,0)
                                new_matrix[1, 0] = num;
                                i--;//(0,0)
                                new_matrix[0, 0] = matrix[i, j];
                                Console.WriteLine("Nearest Top value - " + matrix[i, j]);
                                i++;//(1,0)
                                j++;//(1,1)
                                new_matrix[1, 1] = matrix[i, j];
                                Console.WriteLine("Nearest right value - " + matrix[i, j]);

                                i--;//(0,1)
                                new_matrix[0, 1] = matrix[i, j];
                                Console.WriteLine("Nearest top diagonal right value - " + matrix[i, j]);
                                i++;//(1,1)

                                j--; //(1,0)

                                int k = i;
                                k++;

                                if (k <= row && k - i == 1)
                                {
                                    i++;
                                    new_matrix[2, 0] = matrix[i, j];
                                    Console.WriteLine("Nearest bottom value -  " + matrix[i, j]);
                                    j++;
                                    new_matrix[2, 1] = matrix[i, j];
                                    Console.WriteLine("Nearest bottom  right diagonal value - " + matrix[i, j]);

                                } //to be continued
                                for (a = 0; a < 3; a++)
                                {
                                    for (b = 0; b < 2; b++)
                                    {
                                        if (new_matrix[a, b] == 0)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Console.Write(new_matrix[a, b] + " ");
                                        }

                                    }
                                    Console.WriteLine();
                                }

                            }
                            //for column m and row 1 (last column)
                            else if (j == (column - 1) && i == 0)
                            {
                                //(0,2)
                                new_matrix[0, 1] = num;
                                j--;//(0,1)
                                new_matrix[0, 0] = matrix[i, j];
                                Console.WriteLine("Nearest left value - " + matrix[i, j]);
                                j++;//(0,2)
                                i++;//(2,2)
                                new_matrix[1, 1] = matrix[i, j];
                                Console.WriteLine("Nearest bottom value  - " + matrix[i, j]);
                                j--;//(2,1)

                                new_matrix[1, 0] = matrix[i, j];
                                Console.WriteLine("Nearest bottom diagonal value - " + matrix[i, j]);


                                for (a = 0; a < 2; a++)
                                {
                                    for (b = 0; b < 2; b++)
                                    {
                                        Console.Write(new_matrix[a, b] + " ");
                                    }
                                    Console.WriteLine();
                                }


                            }

                            else if (j == (column - 1) && i >= 1)
                            {

                                //(3,3)
                                new_matrix[1, 1] = num;
                                i--;//(2,3)
                                new_matrix[0, 1] = matrix[i, j];
                                Console.WriteLine("Nearest Top value - " + matrix[i, j]);
                                i++;//(3,3)

                                j--;//(3,2)
                                new_matrix[1, 0] = matrix[i, j];
                                Console.WriteLine("Nearest left value - " + matrix[i, j]);
                                i--;//(2,2)
                                new_matrix[0, 0] = matrix[i, j];
                                Console.WriteLine("Nearest top left diagonal value - " + matrix[i, j]);
                                i++;//(3,2)
                                j++;//(3,3)

                                int k = i;
                                k++;

                                if (k <= row && k - i == 1)
                                {

                                    i++;
                                    // bottom adjacent value
                                    new_matrix[2, 0] = matrix[i, j];
                                    Console.WriteLine("Nearest bottom left diagonal value - " + matrix[i, j]);
                                    i--;


                                    j++;
                                    i++;
                                    new_matrix[2, 1] = matrix[i, j];
                                    Console.WriteLine("Nearest bottom value - " + matrix[i, j]);
                                }

                                //to be continued
                                for (a = 0; a < 3; a++)
                                {
                                    for (b = 0; b < 3; b++)
                                    {
                                        if (new_matrix[a, b] == 0)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Console.Write(new_matrix[a, b] + " ");
                                        }
                                    }
                                    Console.WriteLine();
                                }

                            }
                            else
                            {
                                if ((i == 0 && j >= 1))
                                {    //(0,1)
                                    new_matrix[0, 1] = num;
                                    j++;//(0,2)
                                    new_matrix[0, 2] = matrix[i, j];
                                    Console.WriteLine("Nearest right value - " + matrix[i, j]);

                                    i++;//(1,2)
                                    new_matrix[1, 2] = matrix[i, j];
                                    Console.WriteLine("Nearest top right diagonal value - " + matrix[i, j]);
                                    i--;//(0,2)

                                    j = j - 2; //(0,0)
                                    new_matrix[0, 0] = matrix[i, j];
                                    Console.WriteLine("Nearest left value - " + matrix[i, j]);

                                    i++;//(1,0)
                                    new_matrix[1, 0] = matrix[i, j];
                                    Console.WriteLine("Nearest bottom left diagonal value - " + matrix[i, j]);
                                    i--;//back to row 1


                                    j++;//
                                    i++;//(1,1)
                                    new_matrix[1, 1] = matrix[i, j];
                                    Console.WriteLine("Nearest Bottom Value - " + matrix[i, j]);

                                    for (a = 0; a < 2; a++)
                                    {
                                        for (b = 0; b < 3; b++)
                                        {
                                            Console.Write(new_matrix[a, b] + " ");
                                        }
                                        Console.WriteLine();
                                    }

                                }
                                else
                                {
                                    if (i >= 1 && j >= 1)
                                    {
                                        //(2,1)
                                        new_matrix[1, 1] = num;
                                        i--;//(1,1)
                                        new_matrix[0, 1] = matrix[i, j];
                                        Console.WriteLine("Nearest Top value - " + matrix[i, j]);
                                        j++;//(1,2)
                                        new_matrix[0, 2] = matrix[i, j];
                                        Console.WriteLine("Nearest top right diagonal value - " + matrix[i, j]);
                                        j--;//(1,1)

                                        j--;//(1,0)
                                        new_matrix[0, 0] = matrix[i, j];
                                        Console.WriteLine("Nearest top left diagonal value - " + matrix[i, j]);
                                        j++;//(1,1)


                                        i++; //(2,1)
                                        j--;//(2,0)
                                        new_matrix[1, 0] = matrix[i, j];
                                        Console.WriteLine("Nearest left value - " + matrix[i, j]);


                                        j = j + 2;//(2,2)
                                        new_matrix[1, 2] = matrix[i, j];
                                        Console.WriteLine("Nearest right value - " + matrix[i, j]);

                                        int k = i;
                                        k++;

                                        if (k <= row && k - i == 1)
                                        {

                                            i++;//(3,2)
                                            new_matrix[2, 2] = matrix[i, j];
                                            Console.WriteLine("Nearest bottom right diagonal value - " + matrix[i, j]);
                                            i--;//(2,2)




                                            i++;//(3,2)
                                            j--;//(3,1)
                                            new_matrix[2, 1] = matrix[i, j];
                                            Console.WriteLine("Nearest bottom value - " + matrix[i, j]);
                                            j--;
                                            new_matrix[2, 0] = matrix[i, j];
                                            Console.WriteLine("Nearest bottom left diagonal value - " + matrix[i, j]);
                                        }

                                    }
                                    //to be continued for last row
                                    for (a = 0; a < 3; a++)
                                    {
                                        for (b = 0; b < 3; b++)
                                        {
                                            if (new_matrix[a, b] == 0)
                                            {
                                                continue;
                                            }
                                            else
                                            {
                                                Console.Write(new_matrix[a, b] + " ");
                                            }
                                        }
                                        Console.WriteLine();
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
            catch (Exception e) 
            { Console.WriteLine("Invalid user input.Please enter valid positive intger input only."); }

        }
    }
}
