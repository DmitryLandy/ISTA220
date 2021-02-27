/*
 * Name: Dmitry Landy
 * File: cs-lab7-landy.cs
 * Date: 2/26/2021
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace ex07_roulette
{
    class Program
    {
        static void Main(string[] args)
        {

            //User Prompt:
            programPrompt();

            int selection; //menu selection
            string bet; //user's bet

            while(true)
            {
                selection = menu(); //display menu and gets user's selection
                
                bet = checkSelected(selection); //check's user's bet

                printTable();

                Console.ForegroundColor = ConsoleColor.Yellow;
                int spinResult = spinWheel(); //spin's wheel and get's spin result
                bool result = calculateResult(selection, bet, spinResult);
                
                if(result)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nYou WIN!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou LOSE!");
                }

                
                
            }
        }

        private static bool calculateResult(int selection, string bet, int result)
        {
            switch (selection)
            {
                case 1: //number
                    return calculateNumber(bet, result);

                case 2: //even/odd
                    if (checkZero(result)) return false;
                    return calcEvenOdd(bet,result);

                case 3: //black or red
                    if (result == 0 || result == 37)
                    {
                        Console.WriteLine("Winning Color was Green");
                        return false;
                    }
                    return calculateColor(bet, result);

                case 4: //low/high
                    bool lhRes =(bet.ToLower() == "low") ? result >= 1 && result < 19 : result >= 19 && result != 37;
                    return lhRes;

                case 5://dozens
                    if (checkZero(result)) return false;
                    return calculateDozens(bet, result);
                    
                case 6: //column
                    if (checkZero(result)) return false;
                    return calculateColumn(bet, result);
                    
                case 7: //rows
                    
                    if (checkZero(result)) return false;
                    return calculateRow(bet, result);

                case 8: //Double row
                    
                    if (checkZero(result)) return false;
                    return calculateDoubleRow(bet, result);
                    
                case 9: //split
                    if (checkZero(result)) return false;
                    return calculateSplit(bet, result);

                default: //corner
                    if (checkZero(result)) return false;
                    return calculateCorner(bet, result);
            }
        }

        private static bool calculateColor(string bet, int result)
        {
            //implement array
            int[] bAry = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 35 };
            string resColor = "";
            foreach (int i in bAry)
            {
                if (result == i)
                {
                    resColor = "black";
                    break;
                }
                    
                

                else
                    resColor = "red";
            }
            Console.WriteLine($"Winning Color was {resColor}");
            return bet.ToLower() == resColor;
        }

        private static void programPrompt()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("C# Exercise 07: Roulette");
            Console.WriteLine("\nWelcome to Roulette!" +
                "\nUse the menu to navigate to your desired bet: ");
        }
        private static int spinWheel()
        {
            Console.WriteLine("\nSpinning the Wheel!");
            Random rand = new Random(); //0-36, 37= 00
            int spinResult = rand.Next(38);            
            if (spinResult == 37)
                Console.WriteLine($"The ball landed on 00");
            else
                Console.WriteLine($"The ball landed on {spinResult}");
            return spinResult;
        }

        private static string checkSelected(int selection)
        {
            StringBuilder bet = new StringBuilder();
            switch (selection)
            {

                case 1:
                    Console.Write("Enter Your Number: ");
                    bet.Append(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Even or Odd: ");
                    bet.Append(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Red or Black: ");
                    bet.Append(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("Low or High: ");
                    bet.Append(Console.ReadLine());
                    break;
                case 5:
                    Console.Write("Which Dozen (1, 2, 3): ");
                    bet.Append(Console.ReadLine());
                    break;
                case 6:
                    Console.Write("Which Column (1, 2, 3): ");
                    bet.Append(Console.ReadLine());
                    break;
                case 7:
                    Console.Write("Which Row (1-12): ");
                    bet.Append(Console.ReadLine());
                    break;
                case 8:
                    Console.Write("Which Double Row (1-11): ");
                    bet.Append(Console.ReadLine());
                    break;
                case 9:
                    Console.Write("What two values (separate by comma) ");
                    bet.Append(Console.ReadLine());
                    break;
                case 10:
                    Console.Write("What 4 values (separate by comma) ");
                    bet.Append(Console.ReadLine());
                    break;
                case 11:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("ERROR!");
                    Environment.Exit(0);
                    break;
            }
            return bet.ToString();
        }

        private static bool calculateDozens(string bet, int result)
        {
            int startNum = 0;            

            if (result < 13)
                startNum = 1;
            else if (result < 25)
                startNum = 13;
            else
                startNum = 25;

            Console.WriteLine($"Winning Dozen: {(startNum/12) +1}");

            return int.Parse(bet) - 1 == startNum / 12;
        }

        private static bool calculateColumn(string bet, int result)
        {
            int winColStart;
            if (result % 3 == 0)
                winColStart = 3; //mod 3 = 0 so col needs to say 3
            else
                winColStart = result % 3;

            Console.WriteLine($"Winning Column: {winColStart}");

            return int.Parse(bet) == winColStart;
        }

        private static bool calculateRow(string bet, int result)
        {
            int resultRow = ((result - 1) / 3) + 1;
            int resultStart = (resultRow * 3) - 2;

            //find row of result
            Console.Write($"Winning row: {resultRow}");
            
            return resultRow == int.Parse(bet);
        }

        private static bool calculateDoubleRow(string bet, int result)
        {
            int resultStart2;
            int resultEnd2;
            int resultRowFirst = 0;
            int resultRowSecond = 0;
            bool secondResult = true;

            if (result > 3 && result < 34)
            {
                resultStart2 = ((((result - 1) / 3) + 1) * 3) - 5;
                resultEnd2 = ((((result - 1) / 3) + 1) * 3) + 4;
                resultRowFirst = ((resultStart2 - 1) / 3) + 1;
                resultRowSecond = resultRowFirst + 1;
            }
            else if (result < 4)
            {
                resultStart2 = 1;
                resultEnd2 = 6;
                resultRowFirst = 1;
                secondResult = false;
            }
            else
            {
                resultStart2 = 31;
                resultEnd2 = 36;
                resultRowFirst = 11;
                secondResult = false;
            }

            Console.Write($"Winning rows: {resultRowFirst} ");
            if (secondResult) Console.Write(resultRowSecond);

            return (resultRowFirst == int.Parse(bet) || resultRowSecond == int.Parse(bet));
        }

        private static bool calculateSplit(string bet, int result)
        {
            string[] splitAry = bet.Split(',');
            List<int> partners = new List<int>();

            if (result % 3 == 0)//top row
            {
                partners.Add(result - 1); //below
                if (result - 3 > 0) //does it have something to its left
                    partners.Add(result - 3);//left
                if (result + 3 < 37)// does it have something to its right
                    partners.Add(result + 3);//right
            }
            else if (result % 3 == 2)//mid row
            {
                partners.Add(result + 1);//top
                partners.Add(result - 1);//bottom

                if (result - 3 > 0)
                    partners.Add(result - 3);
                if (result + 3 < 37)
                    partners.Add(result + 3);
            }
            else //bottom row
            {
                partners.Add(result + 1);
                if (result - 3 > 0)
                    partners.Add(result - 3);
                if (result + 3 < 37)
                    partners.Add(result + 3);
            }

            partners.Sort();
            Console.Write($"Winning Split Values: {result}");
            foreach (int i in partners) Console.Write($" ,{i}");

            return int.Parse(splitAry[0]) == result || int.Parse(splitAry[1]) == result;
        }

        private static bool calculateCorner(string bet, int result)
        {
            bool retQuad = false;

            string[] quadAry = bet.Replace(" ", "").Split(',');
            List<int> quadPartners = new List<int>();
            
            if (result % 3 == 0)//top row
            {
                quadPartners.Add(result - 1); //below
                if (result - 3 > 0)
                {
                    quadPartners.Add(result - 3); //left
                    quadPartners.Add(result - 4); //diagonal down left
                }

                if (result + 3 < 37)
                {
                    quadPartners.Add(result + 3); //right
                    quadPartners.Add(result + 2); //diagonal down right
                }

            }
            else if (result % 3 == 2)//mid row
            {
                quadPartners.Add(result + 1);//up
                quadPartners.Add(result - 1);//down

                if (result - 3 > 0)
                {
                    quadPartners.Add(result - 3);//left
                    quadPartners.Add(result - 4); //diagonal down left
                    quadPartners.Add(result - 2); //diagonal up left
                }

                if (result + 3 < 37)
                {
                    quadPartners.Add(result + 3);//right
                    quadPartners.Add(result + 2); //diagonal down right
                    quadPartners.Add(result + 4); //diagonal up right
                }
            }
            else //bottom row
            {
                quadPartners.Add(result + 1);//top
                if (result - 3 > 0)
                {
                    quadPartners.Add(result - 3);//left
                    quadPartners.Add(result - 2);//top left
                }
                if (result + 3 < 37)
                {
                    quadPartners.Add(result + 3);//right
                    quadPartners.Add(result - 4);//top right
                }
            }

            for (int i = 0; i < 4; i++)
                if (int.Parse(quadAry[i]) == result)
                    retQuad = true;

            quadPartners.Sort();
            Console.Write($"Winning Corner Values: {result}");
            foreach (int i in quadPartners)
                Console.Write($" ,{i}");

            return retQuad;
        }

        private static bool checkZero(int result)
        {
            if (result == 0 || result == 37)
            {
                Console.WriteLine("Winning result was 0 or 00");
                return true;
            }
            return false;
        }

        private static bool calcEvenOdd(string bet, int result)
        {
            if (bet.ToLower() == "even") return result % 2 == 0;
            else if (bet.ToLower() == "odd") return result % 2 != 0;
            else Console.WriteLine("Result was 0 or 00");
            
            return false;
        }

        private static bool calculateNumber(string bet, int result)
        {
            if (bet == "00") return result == 37;
            return result == int.Parse(bet);
        }

        private static int menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nMenu: " +
            "\n1.Numbers: the number of the bin" +
            "\n2.Evens / Odds: NOT 0 or 00" +
            "\n3.Reds / Blacks: NOT 0 or 00" +
            "\n4.Lows / Highs: low(1 – 18) or high(19 – 36) numbers." +
            "\n5.Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36" +
            "\n6.Columns: first, second, or third columns" +
            "\n7.Street: rows, e.g., 1 / 2 / 3 " +
            "\n8.Double rows" +
            "\n9.Split: at the edge of any two contiguous numbers, INCLUDING 0/00" +
            "\n10.Corner: at the intersection of any four contiguous numbers, NOT 0/00" +
            "\n11. EXIT PROGRAM!");

            Console.Write("\nSelection: ");

            return int.Parse(Console.ReadLine());
        }

        private static void printTable()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            printHeader();
            printBody();
            printFooter();
                              
            Console.ResetColor();
        }

        private static void printFooter()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(""+
            "|======================================================================|\n" +
            "|       First Dozen    ||       Second Dozen   ||      Third Dozen     |\n" +
            "|                   LOW            ||                 HIGH             |\n");
        }

        private static void printHeader()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"| 01 || 02 || 03 || 04 || 05 || 06 || 07 || 08 || 09 || 10 || 11 || 12 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t| 0 / 00|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("|======================================================================|");
        }

        private static void printBody()
        {
            
            Console.BackgroundColor = ConsoleColor.White;            
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("| 03 |");
            Console.BackgroundColor = ConsoleColor.Black;            
            Console.Write("| 06 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("| 09 |");
            Console.Write("| 12 |");
            Console.BackgroundColor = ConsoleColor.Black;            
            Console.Write("| 15 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("| 18 |");
            Console.Write("| 21 |");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("| 24 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("| 27 |");
            Console.Write("| 30 |");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("| 33 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("| 36 |");            
            Console.ForegroundColor = ConsoleColor.Black;            
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\tColumn 3");
            
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("| 02 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("| 05 |");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("| 08 |");
            Console.Write("| 11 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("| 14 |");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("| 17 |");
            Console.Write("| 20 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("| 23 |");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("| 26 |");
            Console.Write("| 29 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("| 32 |");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("| 35 |");
            Console.ForegroundColor = ConsoleColor.Black;            
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\tColumn 2");
            
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("| 01 |");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("| 04 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("| 07 |");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("| 10 |");
            Console.Write("| 13 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("| 16 |");
            Console.Write("| 19 |");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("| 22 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("| 25 |");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("| 28 |");
            Console.Write("| 31 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("| 34 |");            
            Console.ForegroundColor = ConsoleColor.Black;            
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\tColumn 2");
        }
    }
}


