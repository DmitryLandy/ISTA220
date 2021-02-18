/*
 * Name: Dmitry Landy
 * File: lab12b-extensions-landy.cs
 * Date: 2/18/2021
 */
using System;
using Extensions;

namespace ExtensionMethod
{
    class Program
    {
        static void doWork()
        {
            bool continued = true;
            while(continued)
            {
                Console.Write("Enter a Number: ");
                string inputStr = Console.ReadLine();                
                int x = int.Parse(inputStr);

                if(x < 1)
                {
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                }

                for (int i = 2; i <= 10; i++)
                {
                    Console.WriteLine($"{x} in base {i} is {x.ConvertToBase(i)}");
                }
            }            
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
