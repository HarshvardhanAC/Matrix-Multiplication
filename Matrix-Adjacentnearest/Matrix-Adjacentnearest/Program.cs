/*
 Author :- Harsh Vardhan Acharya
 Date :- 03-04-2024
 Project description :- The project is calculate the nearest and diagonal values of particular value present in matrix.
 User will input values for rows and columns.
 Then user will input value present in matrix and nearest values will be calculted and rest will be 0.
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Nearest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rows and columns :");

            try
            {

                Console.WriteLine("Enter the rows");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the columns");
                int column = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Following matrix is of : - " + row + "x" + column);

                int[,] matrix = new int[row, column];

                Console.WriteLine("Reading Values from user :-");

                for (int i = 0; i < row; i++)
                {
                    Console.WriteLine("Enter the values for column -" + i);
                    for (int j = 0; j < column; j++)
                    {
                        matrix[j, i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Printing the Matrix");

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

                int[,] new_matrix = new int[3, 3];
                int a = 0, b = 0;


                bool broke = false;


                for (int i = 0; i < row; i++)
                {

                    for (int j = 0; j < column; j++)
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

                                j++;
                                new_matrix[2, 2] = matrix[i, j];
                                Console.WriteLine("Nearest bottom right diagonal value " + matrix[i, j]);


                                //storing other values as 0
                                for (a = 0; a < 3; a++)
                                {
                                    for (b = 0; b < 3; b++)
                                    {
                                        if ((new_matrix[a, b] == new_matrix[2, 1]) || (new_matrix[a, b] == new_matrix[1, 2]) || (new_matrix[a, b] == new_matrix[1, 1]) || (new_matrix[a, b] == new_matrix[2, 2]))
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

                            //for column 1
                            else if (i >= 1 && j == 0)
                            {
                                //(1,0)
                                new_matrix[1, 1] = num;
                                i--;//(0,0)
                                new_matrix[0, 1] = matrix[i, j];
                                Console.WriteLine("Nearest Top value " + matrix[i, j]);
                                i++;//(1,0)
                                j++;//(1,1)
                                new_matrix[1, 2] = matrix[i, j];
                                Console.WriteLine("Nearest right value " + matrix[i, j]);

                                i--;//(0,1)
                                new_matrix[0, 2] = matrix[i, j];
                                Console.WriteLine("Nearest top diagonal right value " + matrix[i, j]);
                                i++;//(1,1)

                                j--; //(1,0)

                                int k = i;
                                k++;

                                if (k < row && k - i == 1)
                                {
                                    i++;
                                    new_matrix[2, 1] = matrix[i, j];
                                    Console.WriteLine("Nearest bottom value " + matrix[i, j]);
                                    j++;
                                    new_matrix[2, 2] = matrix[i, j];
                                    Console.WriteLine("Nearest bottom  right diagonal value " + matrix[i, j]);

                                }
                                else
                                {
                                    Console.WriteLine();
                                }
                                for (a = 0; a < 3; a++)
                                {
                                    for (b = 0; b < 3; b++)
                                    {
                                        if ((new_matrix[a, b] == new_matrix[1, 1]) || (new_matrix[a, b] == new_matrix[0, 1]) || (new_matrix[a, b] == new_matrix[1, 2]) || (new_matrix[a, b] == new_matrix[2, 1]) || (new_matrix[a, b] == new_matrix[2, 2]) || (new_matrix[a, b] == new_matrix[0, 2]))
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
                            //for column m and row 1 (last column)
                            else if (j == (column - 1) && i == 0)
                            {
                                //(0,2)
                                new_matrix[1, 1] = num;
                                j--;//(0,1)
                                new_matrix[1, 0] = matrix[i, j];
                                Console.WriteLine("Nearest left value" + matrix[i, j]);
                                j++;//(0,2)
                                i++;//(2,2)
                                new_matrix[2, 1] = matrix[i, j];
                                Console.WriteLine("Nearest bottom value " + matrix[i, j]);
                                j--;//(2,1)

                                new_matrix[2, 0] = matrix[i, j];
                                Console.WriteLine("Nearest bottom diagonal value " + matrix[i, j]);


                                for (a = 0; a < 3; a++)
                                {
                                    for (b = 0; b < 3; b++)
                                    {
                                        if ((new_matrix[a, b] == new_matrix[1, 1]) || (new_matrix[a, b] == new_matrix[1, 0]) || (new_matrix[a, b] == new_matrix[2, 1]) || (new_matrix[a, b] == new_matrix[2, 0]))
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

                            else if (j == (column - 1) && i >= 1)
                            {

                                //(3,3)
                                new_matrix[1, 1] = num;
                                i--;//(2,3)
                                new_matrix[0, 1] = matrix[i, j];
                                Console.WriteLine("Nearest Top value " + matrix[i, j]);
                                i++;//(3,3)

                                j--;//(3,2)
                                new_matrix[1, 0] = matrix[i, j];
                                Console.WriteLine("Nearest left value" + matrix[i, j]);
                                i--;//(2,2)
                                new_matrix[0, 0] = matrix[i, j];
                                Console.WriteLine("Nearest top left diagonal value" + matrix[i, j]);
                                i++;//(3,2)
                                j++;//(3,3)

                                int k = i;
                                k++;

                                if (k < row && k - i == 1)
                                {

                                    i++;
                                    // bottom adjacent value
                                    new_matrix[2, 0] = matrix[i, j];
                                    Console.WriteLine("Nearest bottom left diagonal value" + matrix[i, j]);
                                    i--;


                                    j++;
                                    i++;
                                    new_matrix[2, 1] = matrix[i, j];
                                    Console.WriteLine("Nearest bottom value " + matrix[i, j]);
                                }
                                else
                                {
                                    Console.WriteLine();
                                }

                                for (a = 0; a < 3; a++)
                                {
                                    for (b = 0; b < 3; b++)
                                    {
                                        if ((new_matrix[a, b] == new_matrix[1, 1]) || (new_matrix[a, b] == new_matrix[0, 1]) || (new_matrix[a, b] == new_matrix[1, 0]) || (new_matrix[a, b] == new_matrix[2, 1]) || (new_matrix[a, b] == new_matrix[2, 0]) || (new_matrix[a, b] == new_matrix[0, 0]))
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
                                    j++;//(0,2)
                                    new_matrix[1, 2] = matrix[i, j];
                                    Console.WriteLine("Nearest right value" + matrix[i, j]);

                                    i++;//(1,2)
                                    new_matrix[2, 2] = matrix[i, j];
                                    Console.WriteLine("Nearest top right diagonal value" + matrix[i, j]);
                                    i--;//back to row 1 (0,2)

                                    j = j - 2; //(0,0)
                                    new_matrix[1, 0] = matrix[i, j];
                                    Console.WriteLine("Nearest left value" + matrix[i, j]);

                                    i++;//(1,0)
                                    new_matrix[2, 0] = matrix[i, j];
                                    Console.WriteLine("Nearest bottom left diagonal value" + matrix[i, j]);
                                    i--;//back to row 1(0,0)


                                    j++;//(0,1)
                                    i++;//(1,1)
                                    new_matrix[2, 1] = matrix[i, j];
                                    Console.WriteLine("Nearest Bottom Value" + matrix[i, j]);

                                    for (a = 0; a < 3; a++)
                                    {
                                        for (b = 0; b < 3; b++)
                                        {
                                            if ((new_matrix[a, b] == new_matrix[1, 1]) || (new_matrix[a, b] == new_matrix[1, 2]) || (new_matrix[a, b] == new_matrix[1, 0]) || (new_matrix[a, b] == new_matrix[2, 0]) || (new_matrix[a, b] == new_matrix[2, 2]) || (new_matrix[a, b] == new_matrix[2, 1]))
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
                                        //(2,1)
                                        new_matrix[1, 1] = num;
                                        i--;//(1,1)
                                        new_matrix[0, 1] = matrix[i, j];
                                        Console.WriteLine("Nearest Top value " + matrix[i, j]);
                                        j++;//(1,2)
                                        new_matrix[0, 2] = matrix[i, j];
                                        Console.WriteLine("Nearest top right diagonal value" + matrix[i, j]);
                                        j--;//(1,1)

                                        j--;//(1,0)
                                        new_matrix[0, 0] = matrix[i, j];
                                        Console.WriteLine("Nearest top left diagonal value" + matrix[i, j]);
                                        j++;//(1,1)


                                        i++; //(2,1)
                                        j--;//(2,0)
                                        new_matrix[1, 0] = matrix[i, j];
                                        Console.WriteLine("Nearest left value " + matrix[i, j]);


                                        j = j + 2;//(2,2)
                                        new_matrix[1, 2] = matrix[i, j];
                                        Console.WriteLine("Nearest right value " + matrix[i, j]);

                                        int k = i;
                                        k++;

                                        if (k < row && k - i == 1)
                                        {

                                            i++;//(3,2)
                                            new_matrix[2, 2] = matrix[i, j];
                                            Console.WriteLine("Nearest bottom right diagonal value" + matrix[i, j]);
                                            i--;//(2,2)




                                            i++;//(3,2)
                                            j--;//(3,1)
                                            new_matrix[2, 1] = matrix[i, j];
                                            Console.WriteLine("Nearest bottom value " + matrix[i, j]);
                                            j--;
                                            new_matrix[2, 0] = matrix[i, j];
                                            Console.WriteLine("Nearest bottom left diagonal value" + matrix[i, j]);
                                        }
                                        else
                                        {
                                            Console.WriteLine();
                                        }

                                    }
                                    else { Console.WriteLine(); }

                                    for (a = 0; a < 3; a++)
                                    {
                                        for (b = 0; b < 3; b++)
                                        {
                                            if ((new_matrix[a, b] == new_matrix[1, 1]) || (new_matrix[a, b] == new_matrix[0, 1]) || (new_matrix[a, b] == new_matrix[1, 0]) || (new_matrix[a, b] == new_matrix[2, 1]) || (new_matrix[a, b] == new_matrix[1, 2]) || (new_matrix[a, b] == new_matrix[0, 0]) || (new_matrix[a, b] == new_matrix[0, 2]) || (new_matrix[a, b] == new_matrix[2, 2]) || (new_matrix[a, b] == new_matrix[2, 0]))
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
                           // Console.WriteLine("Number not found");
                              //  break;                          
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
            catch(Exception e)
            {
                Console.WriteLine("Invalid user input.Please enter the valid positive intger value only");
            }

        }
    }
}
