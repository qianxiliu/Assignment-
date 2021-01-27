using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment1_Spring2021
{
    class Program
    {




        //Question 1
        private static void printTriangle(int n)//create a new method which invoke by the method PrintPattern
        {


            try
            {
                int i, j;

                Console.WriteLine("Q1 : Enter the number of rows for the traingle:");

                n = Convert.ToInt32(Console.ReadLine());

                for (i = 0; i < n; i++)
                {
                    for (j = 1; j <= n - i; j++)
                        Console.WriteLine(" ");
                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    

                }


                printTriangle(n);
                Console.WriteLine();

            }
            catch (Exception)
            {
                throw;
            }
        }

                

              
            


        
    }
}


