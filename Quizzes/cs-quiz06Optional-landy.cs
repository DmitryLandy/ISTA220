/*
 * Name: Dmitry Landy
 * File: cs-optionalQuiz06-landy.cs
 * Date: 2/11/2021
 */
using System;

namespace quiz06
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] aryNum = new int[52]; //holds 52 ints    

            //create four hands
            int[] north = new int[13];
            int[] east = new int[13];
            int[] south = new int[13];
            int[] west = new int[13];

            //array of hands
            int[][] handsAry = { north, east, south, west };
            string[] handsNames = { "North", "East", "South", "West" };

            //Initialize the array with integers 0 through 51.
            for (int x = 0; x < aryNum.Length; x++)                
                aryNum[x] = x;
           
            Console.WriteLine("This is C# (Optional) Quiz 6");

            Console.WriteLine("\n Initialize new deck===========================\n");
            for (int i = 0; i < aryNum.Length; i++)
            {
                printCardInfo(i);
                Console.Write(", ");
            }

            //sorts deck into 4 hands
            sortDeck(aryNum, handsAry);            

            Console.WriteLine("\n \nDeal from new deck===========================\n");
            dealDeck(handsAry, handsNames);
        }

        private static void dealDeck(int[][] handsAry, string[] handsNames)
        {
            for (int i = 0; i < 13; i++) //iterate through whole hand
            {
                for (int x = 0; x < handsAry.Length; x++) //iterate through each hand
                {
                    Console.Write($"~~{handsNames[x]}~~  ");
                    printCardInfo(handsAry[x][i]);
                    Console.WriteLine();
                }
            }
        }

        private static void sortDeck(int[] aryNum, int[][] handsAry)
        {
            //random number generator
            Random rand = new Random();

            for (int i = 0; i < 13; i++)
            {
                for (int hand = 0; hand < handsAry.Length; hand++)
                {
                    int num;
                    do
                        num = rand.Next(52);
                    while (aryNum[num] == -1);

                    aryNum[num] = -1;

                    handsAry[hand][i] = num;
                }
            }
        }

        private static void printCardInfo(int cardNum)
        {
            string[] suits = {"Clubs", "Diamonds", "Hearts", "Spades"};
            String[] values = {"two", "three", "four", "five", "six", "seven", "eight", "nine",
                "ten", "Jack", "Queen", "King", "Ace"};  

            int value = cardNum%13;
            int suit = cardNum/13;

            string cardInfo = $"{values[value]} of {suits[suit]}";
            Console.Write(cardInfo);

            
        }
    }
}
