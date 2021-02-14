/*
 * Name: Dmitry Landy
 * File: Cs-ex05-landy.cs
 * Date: 2/13/2021
 */
using System;

namespace cs_ex05_landy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aryA = { 0, 2, 4, 6, 8, 10 };
            int[] aryB = { 1, 3, 5, 7, 9 };
            int[] aryC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine("C# Exercise 5: ");

            // Part 1: Counting, summing, computing the mean:
            double aryAvgA = makeAryAvg(aryA);
            double aryAvgB = makeAryAvg(aryB);
            double aryAvgC = makeAryAvg(aryC);

            Console.WriteLine($"\nThe Following is the Mean of each array: " +
                $"\nArray A: {aryAvgA}" +
                $"\nArray B: {aryAvgB}" +
                $"\nArray C: {aryAvgC}");

            // Part 2: Reversing arrays
            string revAryA = reverseAry(aryA);
            string revAryB = reverseAry(aryB);
            string revAryC = reverseAry(aryC);

            Console.WriteLine($"\nThe Following is the Reverse of each array: " +
                $"\nArray A: [{revAryA}]" +
                $"\nArray B: [{revAryB}]" +
                $"\nArray C: [{revAryC}]");

            // Part 3: Rotating Arrays
            string rotAryA = rotateAry("left", 2, aryA);
            string rotAryB = rotateAry("right", 2, aryB);
            string rotAryC = rotateAry("left", 4, aryC);

            Console.WriteLine($"\nThe Following is each array rotated: " +
                $"\nArray A: [{rotAryA}]" +
                $"\nArray B: [{rotAryB}]" +
                $"\nArray C: [{rotAryC}]");

            // Part 4: Sort Arrays
            string sortAryA = sortAry(aryA);
            string sortAryB = sortAry(aryB);
            string sortAryC = sortAry(aryC);

            Console.WriteLine($"\nThe Following is each array sorted: " +
                $"\nArray A: [{sortAryA}]" +
                $"\nArray B: [{sortAryB}]" +
                $"\nArray C: [{sortAryC}]");

        }

        private static string sortAry(int[] ary)
        {
            string sortAryStr = "";

            while (!fullySorted(ary))
            {
                for (int x = 0; x < ary.Length-1; x++)
                {
                int current = x;
                int next = x+1;                

                    if(ary[current]>ary[next])
                    {
                        //swap values
                        int temp = ary[next];                        
                        ary[next] = ary[current];                        
                        ary[current] = temp;                       
                    }                    
                }
           }
            
            sortAryStr = string.Join(",", ary);
            return sortAryStr;
        }

        private static bool fullySorted(int[] sortedAry)
        {            
            for(int x =0; x < sortedAry.Length-1; x++)
            {
                int next = x + 1;
                if (sortedAry[x] > sortedAry[next])
                    return false;
            }
            return true;
        }

        private static string rotateAry(string direction, int numPlaces, int[] ary)
        {
            int arySize = ary.Length;
            int[] rotAry = new int[arySize];
            string rotAryStr = "";
            int newPlace;

            // move place right: (position + change) % length of array
            // move place left: (size + position - change) % size
            for (int x = 0; x < arySize; x++)
            {
                if (direction.Equals("left"))
                {
                    newPlace = (arySize + x - numPlaces) % arySize;
                    rotAry[newPlace] = ary[x];
                }

                else //right
                {
                    newPlace = (x + numPlaces) % arySize;
                    rotAry[newPlace] = ary[x];
                }
            }
            rotAryStr = string.Join(",", rotAry);
            return rotAryStr;
        }

        private static string reverseAry(int[] ary)
        {
            int[] revAry = new int[ary.Length];
            string revAryStr = "";
            for (int x = ary.Length - 1; x >= 0; x--)
                revAry[(ary.Length) - (x+1)] = ary[x];

            revAryStr = string.Join(",", revAry);

            return revAryStr;
        }

        private static double makeAryAvg(int[] ary)
        {
            int count = 0;
            int sum = 0;
            foreach (int x in ary)
            {
                count++;
                sum += x;
            }

            return (double)sum / count;            
                
        }
    }
}
