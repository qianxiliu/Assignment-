using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment1_Spring2021
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = 5;
            PrintTriangle(n);
        }


            //Question 1
            private static void PrintTriangle(int n)//create a new method which invoke by the method PrintPattern
            {


                try
                {
                    int i, j,k;

                    Console.WriteLine("Q1 : Enter the number of rows for the traingle:");

                    n = Convert.ToInt32(Console.ReadLine());

                    for (i = 1; i<=n; i++)
                    {
                        for (j = n; j >= i; j--)
                        {
                        Console.Write(" ");
                        }

                       for (k = 1; k <= (2*i-1); k++)
                       {
                        Console.Write("*");
                       }

                    Console.WriteLine();
                    }
                

                    PrintTriangle(n);
                    Console.ReadLine();

                }
                catch (Exception)
                {
                throw;
                }
            }
        

                

              
            


        
    }
}


