/*
 * Name: Dmitry Landy
 * File: CS-Ex08-Landy.cs
 * Date: 3/5/2021
 */
using System;

namespace GuessMyNumber
{
    class Program
    {
        public static int _value;
        public static int _humanSecret;
        public static int _compGuess;
        public static int _count;
        public static int _min;
        public static int _max;

        static void Main(string[] args)
        {
            Console.WriteLine("C# Exercise 08: Guess My Number\n\n" +
                "Select your game:\n" +
                "[1] Test Bisection Algorithm\n" +
                "[2] Guess My Number: Human Plays\n" +
                "[3] Guess My Number: Computer Plays\n");

            while (checkInputError(1, 3)) ;

            if (_value == 1) playBisectionTest();
            else if (_value == 2) playGuessHuman();
            else playGuessComputer();
           
        }

        private static void playGuessComputer()
        {
            //human chooses number
            Console.Write("Human, choose the secret number. ");
            while (checkInputError(1, 100)) ;
            _humanSecret = _value;
            _count = 0;
            _min = 1;
            _max = 100;

            while(true)
            {
                computerGuess();
                checkComp();
            }
        }

        private static void checkComp()
        {
            _count++;
            // human says if high, low, or correct
            Console.WriteLine("Human, choose the following: \n" +
                "[1] Correct\n" +
                "[2] Too Low\n" +
                "[3] Too High\n");

            while (checkInputError(1, 3)) ;

            if (_value == 1)
            {
                Console.WriteLine($"Human says guess was CORRECT!\n" +
                    $"\nThe guess was {_compGuess} and the real value was {_humanSecret}\n" +
                    $"It took the computer {_count} tries");
                Environment.Exit(0);
            }
            else if (_value == 2)
            {
                Console.WriteLine($"Human says guess is too LOW");
                
                _min = _compGuess + 1;
            }
            else if (_value == 3)
            {
                Console.WriteLine($"Human says guess too HIGH");
                
                _max = _compGuess - 1;
            }
        }

        private static void computerGuess()
        {
            //computer guesses
            Console.WriteLine($"\nCurrent value range: {_min} - {_max}");
            _compGuess = (_min + _max) / 2;
            Console.WriteLine($"Computer Guesses: {_compGuess}");
            Console.WriteLine($"Secret value is : {_humanSecret}");
        }

        private static void playGuessHuman()
        {
            //computer chooses between 1 and 1000
            var randGen = new Random();
            var secret = randGen.Next(1, 1001);            

            while(true)
            {
                //human guesses the number
                while (checkInputError(1, 1000)) ;

                //Correct, Too High or Too Low
                checkGuess(secret);
            }
        }

        private static void checkGuess(int secret)
        {
            var compared = _value.CompareTo(secret);
            var print = "";
            if (compared == 0)
            {
                Console.WriteLine($"Your guess was CORRECT!\n" +
                    $"It took you {_count} tries!");

                Environment.Exit(0);
            }
            else
                print = (compared <0) ?
                "Your guess was too LOW!" : "Your guess was too High";

            Console.WriteLine(print);
            _count++;
        }

        private static void playBisectionTest()
        {
            //Part 1
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            while (checkInputError(1,10)) ;            

            bisectionSearch(_value, list);
        }

        private static bool checkInputError(int min, int max)
        {
            Console.Write($"Select int {min}-{max}: ");
            try
            {
                var input = int.Parse(Console.ReadLine());
                if (input > max || input < min) throw new Exception();
                _value = input;
                return false;

            }
            catch (Exception)
            {
                Console.WriteLine("Try again");
                return true;
            }

        }

        private static void bisectionSearch(int value, int[] list)
        {
            int[] newList = new int[list.Length / 2];

            Console.WriteLine($"\n\nValue: {value}");
            Console.Write($"int[] list =");
            printList(list);

            //find middle value of list
            var midValue = list[((list.Length+1) / 2) -1];
            Console.WriteLine($"\nMiddle Value is {midValue}");

            //compare current value to middle value
            var compared = value.CompareTo(midValue);

            //check comparison
            if(compared==0)
            {
                Console.WriteLine($"The value Searched for, {value}, has been found!");
                Environment.Exit(0);
            }

            //create new list 
            else if(compared >0)
            {
                Console.WriteLine($"Value is greater than {midValue}");
                for (var x = 0; x < newList.Length; x++)
                {
                    newList[x] = list[x + newList.Length];
                }
            }

            else
            {
                Console.WriteLine($"Value is lower than {midValue}");
                for (var x = 0; x < newList.Length; x++)
                {
                    newList[x] = list[x];
                }
            }

            bisectionSearch(value, newList);
        }

        private static void printList(int[] list)
        {
            foreach (var x in list)
                Console.Write($" {x}");
        }
    }

    
}


