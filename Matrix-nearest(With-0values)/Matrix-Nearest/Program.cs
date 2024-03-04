/*
 
Author :- Harsh Vardhan Acharya
Date :- 04-03-2024
Project Description :- The project is to calculate the nearest values(top,bottom,left,right) of matrix.
User will input values for rows and columns.
Then user will enter one value from the martix and the result will printed on the screen of nearest values

  */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Nearest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rows and columns :");

            Console.WriteLine();

            try
            {

                Console.WriteLine("Enter the rows."); 
                int rows = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter the columns");
                int columns = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Following matrix is of : - " + rows + "x" + columns);

                int[,] matrix = new int[rows, columns];

                Console.WriteLine("Reading Values from user :-");

                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine("Enter the values for column -" + i);
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[j, i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Printing the Matrix");

                for (int i = 0; i < rows; i++)
                {

                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Enter one of the value present in matrix");
                int num = Convert.ToInt32(Console.ReadLine());

                int[,] new_matrix = new int[3, 3];
                int a = 0, b = 0;

                for (int i = 0; i < rows; i++)
                {

                    for (int j = 0; j < columns; j++)
                    {
                        if (matrix[i, j] == num)
                        {
                            if (i == 0 && j == 0)
                            {
                                new_matrix[1, 1] = num;
                                j++;
                                new_matrix[1, 2] = matrix[i, j];
                                Console.WriteLine("Nearest right value " + matrix[i, j]);
                                j--;
                                i++;
                                new_matrix[2, 1] = matrix[i, j];
                                Console.WriteLine("Nearet bottom value " + matrix[i, j]);

                                //storing other values as 0
                                for (a = 0; a < 3; a++)
                                {
                                    for (b = 0; b < 3; b++)
                                    {
                                        if ((new_matrix[a, b] == new_matrix[2, 1]) || (new_matrix[a, b] == new_matrix[1, 2]) || (new_matrix[a, b] == new_matrix[1, 1]))
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            new_matrix[a, b] = 0;
                                        }
                                    }
                                }

                            }
                            else if (i >= 1 && j == 0)
                            {
                                new_matrix[1, 1] = num;
                                i--;
                                new_matrix[0, 1] = matrix[i, j];
                                Console.WriteLine("Nearest Top value " + matrix[i, j]);
                                i++;
                                j++;
                                new_matrix[1, 2] = matrix[i, j];
                                Console.WriteLine("Nearest right value " + matrix[i, j]);
                                j--;

                                int k = i;
                                k++;

                                if (k < rows && k - i == 1)
                                {
                                    i++;
                                    new_matrix[2, 1] = matrix[i, j];
                                    Console.WriteLine("Nearest bottom value " + matrix[i, j]);
                                }
                                for (a = 0; a < 3; a++)
                                {
                                    for (b = 0; b < 3; b++)
                                    {
                                        if ((new_matrix[a, b] == new_matrix[1, 1]) || (new_matrix[a, b] == new_matrix[0, 1]) || (new_matrix[a, b] == new_matrix[1, 2]) || (new_matrix[a, b] == new_matrix[2, 1]))
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            new_matrix[a, b] = 0;
                                        }
                                    }
                                }

                            }

                            else if (j == (columns - 1) && i == 0)
                            {
                                new_matrix[1, 1] = num;
                                j--;
                                new_matrix[1, 0] = matrix[i, j];
                                Console.WriteLine("Nearest left value" + matrix[i, j]);
                                j++;
                                i++;
                                new_matrix[2, 1] = matrix[i, j];
                                Console.WriteLine("Nearest bottom value " + matrix[i, j]);

                                for (a = 0; a < 3; a++)
                                {
                                    for (b = 0; b < 3; b++)
                                    {
                                        if ((new_matrix[a, b] == new_matrix[1, 1]) || (new_matrix[a, b] == new_matrix[1, 0]) || (new_matrix[a, b] == new_matrix[2, 1]))
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            new_matrix[a, b] = 0;
                                        }
                                    }
                                }


                            }

                            else if (j == (columns - 1) && i >= 1)
                            {
                                new_matrix[1, 1] = num;
                                i--;
                                new_matrix[0, 1] = matrix[i, j];
                                Console.WriteLine("Nearest Top value " + matrix[i, j]);
                                i++;
                                j--;
                                new_matrix[1, 0] = matrix[i, j];
                                Console.WriteLine("Nearest left value" + matrix[i, j]);



                                int k = i;
                                k++;

                                if (k < rows && k - i == 1)
                                {
                                    j++;
                                    i++;
                                    new_matrix[2, 1] = matrix[i, j];
                                    Console.WriteLine("Nearest bottom value " + matrix[i, j]);
                                }

                                for (a = 0; a < 3; a++)
                                {
                                    for (b = 0; b < 3; b++)
                                    {
                                        if ((new_matrix[a, b] == new_matrix[1, 1]) || (new_matrix[a, b] == new_matrix[0, 1]) || (new_matrix[a, b] == new_matrix[1, 0]) || (new_matrix[a, b] == new_matrix[2, 1]))
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            new_matrix[a, b] = 0;
                                        }
                                    }
                                }

                            }
                            else
                            {
                                if ((i == 0 && j >= 1))
                                {
                                    new_matrix[1, 1] = num;
                                    j++;
                                    new_matrix[1, 2] = matrix[i, j];
                                    Console.WriteLine("Nearest right value" + matrix[i, j]);
                                    j = j - 2;
                                    new_matrix[1, 0] = matrix[i, j];
                                    Console.WriteLine("Nearest left value" + matrix[i, j]);
                                    j++;
                                    i++;
                                    new_matrix[2, 1] = matrix[i, j];
                                    Console.WriteLine("Nearest Bottom Value" + matrix[i, j]);

                                    for (a = 0; a < 3; a++)
                                    {
                                        for (b = 0; b < 3; b++)
                                        {
                                            if ((new_matrix[a, b] == new_matrix[1, 1]) || (new_matrix[a, b] == new_matrix[1, 2]) || (new_matrix[a, b] == new_matrix[1, 0]) || (new_matrix[a, b] == new_matrix[2, 1]))
                                            {
                                                continue;
                                            }
                                            else
                                            {
                                                new_matrix[a, b] = 0;
                                            }
                                        }
                                    }

                                }
                                else
                                {
                                    if (i >= 1 && j >= 1)
                                    {
                                        new_matrix[1, 1] = num;
                                        i--;
                                        new_matrix[0, 1] = matrix[i, j];
                                        Console.WriteLine("Nearest Top value " + matrix[i, j]);
                                        i++;
                                        j--;
                                        new_matrix[1, 0] = matrix[i, j];
                                        Console.WriteLine("Nearest left value " + matrix[i, j]);
                                        j = j + 2;
                                        new_matrix[1, 2] = matrix[i, j];
                                        Console.WriteLine("Nearest right value " + matrix[i, j]);

                                        int k = i;
                                        k++;

                                        if (k < rows && k - i == 1)                        //(n - (2 * i - 1) == 1)
                                        {
                                            i++;
                                            j--;
                                            new_matrix[2, 1] = matrix[i, j];
                                            Console.WriteLine("Nearest bottom value " + matrix[i, j]);
                                        }

                                    }

                                    for (a = 0; a < 3; a++)
                                    {
                                        for (b = 0; b < 3; b++)
                                        {
                                            if ((new_matrix[a, b] == new_matrix[1, 1]) || (new_matrix[a, b] == new_matrix[0, 1]) || (new_matrix[a, b] == new_matrix[1, 0]) || (new_matrix[a, b] == new_matrix[2, 1]) || (new_matrix[a, b] == new_matrix[1, 2]))
                                            {
                                                continue;
                                            }
                                            else
                                            {
                                                new_matrix[a, b] = 0;
                                            }
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

                Console.WriteLine("Printing the matrix of nearest values");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(new_matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid user input.Please enter valid positive integer");
            }



        }
    }
}
