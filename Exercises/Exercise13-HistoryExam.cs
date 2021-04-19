/*
 * Name: Dmitry Landy
 * Date: 4/14/2021
 * File: Ex 13- History Exam
 */
using System;
using System.Collections.Generic;

namespace ex13_History
{
    class Program
    {
        public static List<string[]> _historyDataList;
        public static Random _rand = new Random();
        public static int _totalCorrect;

        static void Main(string[] args)
        {
            
            
            int totalQuestions = init();
            printExam(getTestQuestions(totalQuestions)); //prints exam after getting the requested number of questions
            printResults(totalQuestions);

        }

        private static int init()
        {
            Console.WriteLine("History Exam\n\nInitializing....");
            _historyDataList = InitFile._parsedList;
            Console.Write($"Test Bank Initialized to {_historyDataList.Count} lines\n" +
                $"How Many Question would you like (1-15)?   ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Test Generated with {num} questions\n");
            return num;
        }

        private static void printResults(int totalQuestions)
        {            
            double grade = Math.Round(((double)_totalCorrect / (double)totalQuestions)*100,2);
            Console.WriteLine($"You answered {_totalCorrect} out of {totalQuestions} and your grade is {grade}");
        }

        private static void printExam(List<string[]> testQuestions)
        {            
            foreach (var item in testQuestions)
            {
                printQuestion(item);
            }
            
        }

        private static void printQuestion(string[] questionSet)
        {
            int randIndex = _rand.Next(1, 4);
            (questionSet[1], questionSet[randIndex]) = (questionSet[randIndex], questionSet[1]); //put and swap correct answer in random place


            Console.WriteLine($"\n{questionSet[0]}");//print question

            for (int i = 1; i < questionSet.Length; i++)
            {
                Console.WriteLine($"\t{i} {questionSet[i]}");             
            }

            Console.Write("Enter the Answer: ");
            int answer = int.Parse(Console.ReadLine());

            bool isCorrect = checkAnswer(answer, randIndex, questionSet[randIndex]);
            if (isCorrect) _totalCorrect++;

        }

        private static bool checkAnswer(int answer, int correctAnswer, string answerString)
        {
            bool isCorrect = answer == correctAnswer;
            string printResponse = isCorrect ? "Correct! Well Done" : $"Wrong, The correct answer is {answerString}";
            Console.WriteLine(printResponse);
            return isCorrect;
        }

        //find number of random questions from the total questions list
        private static List<string[]> getTestQuestions(int questionCount)
        {
            var questionAry = new List<string[]>();            
            int randIndex;

            for (int i = 0; i < questionCount; i++)
            {
                randIndex= _rand.Next(_historyDataList.Count);
                questionAry.Add(_historyDataList[randIndex]);
                _historyDataList.RemoveAt(randIndex);
            }   
            return questionAry;

        }
    }

    class InitFile
    {
        public static List<string> _historyList = readfile();
        public static List<string[]> _parsedList = parseList(_historyList);

        //parses the lines to get a list string arrays (which were split on the comma)
        private static List<string[]> parseList(List<string> historyList)
        {
            List<string[]> parsedList = new List<string[]>();

            string pattern = "\".\"|\"";

            foreach (var item in historyList)
            {
                parsedList.Add(Regex.Split(item, pattern));
            }

            for (int i = 0; i < parsedList.Count; i++)
            {
                var currentAry = parsedList.ElementAt(i).ToList();
                currentAry.RemoveAt(0);
                currentAry.RemoveAt(currentAry.Count - 1);
                parsedList[i] = currentAry.ToArray();
            }

            return parsedList;
        }

        //reads file and returns a list of lines (rows) from the file
        private static List<string> readfile()
        {
            var filePath = @"C:\Users\dmitr\source\repos\CSharpProjects\ex13-History\ex13File.csv";
            var historyList = new List<string>();
            using (var reader = new StreamReader(File.OpenRead(filePath)))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    historyList.Add(line);
                }
            }

            for (int i = 0; i < historyList.Count; i++)
            {

            }

            return historyList;
        }
    }
}
