using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        private static string line;

        static void Main(string[] args)
        {
            //characters to be printed out
            int val = 5;
            int i, j, k;
            int n;


            //ask for user input
            Console.WriteLine
                ("Choose your Shape:  1-Triangle 2-Rectangle 3-square 4-diamond 0 - done");
            //add code to read user choice
            do
            {
                string line = Console.ReadLine();


                //case for output and loops to print
                switch (line)
                {
                    case "1":
                        for (i = 1; i <= val; i++)
                        {
                            for (j = 1; j <= i; j++)
                            {
                                Console.Write("");
                            }
                            for (k = 1; k <= i; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine("");
                        }
                        break;

                    case "2":
                        n = 6;
                        for (int row = 1; row <= n; row++)
                        {
                            for (int col = 1; col <= n; col++)
                            {
                                if (row == 1 || row == n)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    if (col == 1 || col == n)
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.Write("*");
                                    }
                                }
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "3":
                        n = 4;
                        for (int row = 1; row <= n; row++)
                        {
                            for (int col = 1; col <= n; col++)
                            {
                                if (row == 1 || row == n)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    if (col == 1 || col == n)
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.Write("*");
                                    }
                                }
                            }
                            Console.WriteLine();
                        }

                        for (int row = 1; row <= n; row++)
                        {
                            for (int col = 1; col <= n; col++)
                            {
                                if (row == 1 || row == n)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    if (col == 1 || col == n)
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.Write("*");
                                    }
                                }
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "4":
                        n = 5;
                        for (i = 1; i <= n; i++)
                        {
                            for (j = 0; j < (n - i); j++)
                            {
                                Console.Write(" ");
                            }
                            for (j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }

                            for (k = 1; k < i; k++)
                            {
                                Console.Write("*");
                            }

                            Console.WriteLine();
                        }

                        for (i = n - 1; i >= 1; i--)
                        {
                            for (j = 0; j < (n - i); j++)
                                Console.Write(" ");
                            for (j = 1; j <= i; j++)
                                Console.Write("*");
                            for (k = 1; k < i; k++)
                                Console.Write("*");
                            Console.WriteLine();
                        }
                        break;

                    //if something other than 1 2 3 4 input

                    default:
                        Console.ReadLine();

                        break;
                }//end switch for shapes

            } while (line != "0"); 

        
        }//end Main Method
     
    }//end class
}//end namespace
