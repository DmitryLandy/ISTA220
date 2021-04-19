//Name: Dmitry Landy
//Date: 4/11/2021
//File: Ex12-MathGames-landy.cs

using System;

namespace ex12_MathGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quiz 12: Math Games\n");

            (int numQs, int choice) = printMenu();

            MathSet.genSet(numQs,choice);
        }

        private static (int, int) printMenu()
        {
            int choice;
            int numQuestions;

            Console.Write("" +
                "[1] Add \n" +
                "[2] Subtract\n" +
                "[3] Multiply\n" +
                "[4] Divide\n\n" +
                "Choice: ");

            choice = int.Parse(Console.ReadLine());

            Console.Write("How Many questions (1-12): ");
            numQuestions = int.Parse(Console.ReadLine());

            return (numQuestions, choice);
        }
    }

    public static class MathSet
    {
        private static Random _rand = new Random();

        private static int getNum() => _rand.Next(1, 13);
        private static bool genSubtractQuestion(int choice)
        {
            var num1 = getNum();
            var num2 = getNum();

            if (num1 < num2) (num1, num2) = (num2, num1);

            (var answer, char mathOperator) = calcAnswer(num1, num2, choice);
            Console.Write($"{num1} {mathOperator} {num2} = ");
            decimal guess = decimal.Parse(Console.ReadLine());

            var result = answer == guess;
            var printResult = (result) ? "Correct!" : $"Wrong! The correct answer was {answer}";
            Console.WriteLine(printResult);
            return result;
        }

        private static (decimal, char) calcAnswer(decimal num1, decimal num2, int choice)
        {
            char mathOp;
            decimal answer;

            switch (choice)
            {
                case 1://add
                    mathOp = '+';
                    answer = num1 + num2;
                    break;
                case 2://subtract
                    mathOp = '-';
                    answer = num1 - num2;
                    break;
                case 3://multiply
                    mathOp = '*';
                    answer = num1 * num2;
                    break;
                default://divide
                    mathOp = '/';

                    answer = (int)((num1 / num2) * 100);
                    answer /= 100;
                    break;
            }
            return (answer, mathOp);
        }

        public static void genSet(int numQuestions, int choice)
        {
            var correctCount = 0;
            for (int i = 0; i < numQuestions; i++)
            {
                if (genSubtractQuestion(choice)) correctCount++;
            }
            int grade = (correctCount * 100) / numQuestions;
            Console.WriteLine($"You got {correctCount} out of {numQuestions} and your grade is {grade}");
        }
    }
}
