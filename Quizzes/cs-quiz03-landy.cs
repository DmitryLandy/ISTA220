/*
 * Name: Dmitry Landy
 * File: csEx03-landy.cs
 * Date: 1/28/2021
 */
using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C Shaprt quiz 3");

            while (promptUser());                
        }

        private static bool promptUser()
        {
            try
            {                
                Console.Write("To calculate the reciprocal of an integer," +
                    "enter a positive integer: ");
                int inputNum = int.Parse(Console.ReadLine());

                if (inputNum == 0)
                    throw new DivideByZeroException("Attempted to divide by zero");
                else if (inputNum < 0)
                    throw new Exception("Your number must be a positive number");
                double reciprocal = 1 / (double)inputNum;

                Console.WriteLine($"The reciprocal of {inputNum} is {reciprocal}");
                return false;
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                return true;
            }
            catch (DivideByZeroException divZeroEx)
            {
                Console.WriteLine(divZeroEx.Message);
                return true;
            }
            catch (Exception negEx)
            {
                Console.WriteLine(negEx.Message);
                return true;
            }
        }
    }
}
