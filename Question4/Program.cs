// See https://aka.ms/new-console-template for more information
using System;

namespace ProblemSet
{
    class Question4
    {
        static void Main(string[] args)
        {
            int[] Num = new int[10];
            int[] evenNum = new int[10];
            int[] oddNum = new int[10];
            
            int a, b = 0, c = 0, n;


            
            Console.Write("Enter the numbers to be stored :");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Input {0} numberss : ", n);
            for (a = 0; a < n; a++)
            {
                Console.Write("element - {0} : ", a);
                Num[a] = Convert.ToInt32(Console.ReadLine());
            }

            
            for (a = 0; a < n; a++)
            {
                if (Num[a] % 2 == 0)
                {
                    evenNum[b] = Num[a];
                    b++;
                }
                else
                {
                    oddNum[c] = Num[a];
                    c++;
                }
            }

            Console.Write("The Even numbers are : ");
            for (a = 0; a < b; a++)
            {
                Console.Write("{0} ", evenNum[a]);
            }

            Console.Write("The Odd numbers are : ");
            for (a = 0; a < c; a++)
            {
                Console.Write("{0} ", oddNum[a]);
            }
            Console.ReadLine();
        }



    }
}
