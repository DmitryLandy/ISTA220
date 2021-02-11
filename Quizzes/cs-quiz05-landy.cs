/*
 * Name: Dmitry Landy
 * File: cs-quiz05-landy.cs
 * Date: 2/11/2021
 */
using System;

namespace quiz05
{
    class Program
    {
        static void Main(string[] args)
        {

            string quote = "Life is like a box of chocolates";
            string[] quoteAry = new string[7];

            quoteAry = quote.Split(" ");

            Console.WriteLine("This is C# Quiz 5");
            Console.WriteLine($"The quote is [{quote}]");
            Console.WriteLine($"Length of the string array is {quoteAry.Length}");

            for(int place = quoteAry.Length-1; place>=0; place--)
            {
                Console.WriteLine($"{place} {quoteAry[place]}");
            }


        }
    }
}
