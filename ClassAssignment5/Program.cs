﻿using System;

namespace ClassAssignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Addition = true;
            while (Addition == true)
            {
                Addition = Add();
            }
            Console.ReadLine();

        }
        
        
       
        private static bool Add()
        {
            int i, n, sum;

            Console.WriteLine("Type a number ");

            if (int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write(" + ");
                if (int.TryParse(Console.ReadLine(), out i))
                {
                    sum = i + n;
                    Console.Write("The sum of the numbers is :");
                    Console.WriteLine(sum);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                Console.WriteLine("enter a valid number");
                return false;
            }
            
               
         /*   double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Select + operator ");

            string Add = Console.ReadLine();

            Console.Write("Type a number ");

            double b = Convert.ToDouble(Console.ReadLine());

           if (Add == "+")
            {
                Console.Write(a + b);
            }
           else
            {
                Console.WriteLine("invalid statment");
            }
            Console.ReadLine();
           */


           
        }
        

    }
}
