/*
 * Name: Dmitry Landy
 * File: Exercise8-landy.cs
 * Date: 3/21/2021
 */
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PasswordAuth
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) run();
        }

        private static void run()
        {
            int selection;
            bool checkStatus;

            do
            {
                printUI();
                (selection, checkStatus) = (verifyInput());
            } while (!checkStatus);

            //display page based on selection
            displayPage(selection);
        }

        private static void displayPage(int selection)
        {
            
            Users.printLine();
            switch (selection)
            {
                case 1:
                    Users.getNewUser();
                    break;
                case 2:
                    Users.getUser();
                    break;
                default:
                    Users.printUsers();
                    Environment.Exit(0);
                    break;
            }
        }

        
        private static (int i, bool b) verifyInput()
        {
            //read input
            
            int num;
            string input = Console.ReadLine();
            bool check = int.TryParse(input, out num);             
                
            if(check)
            {
                check = num > 0 && num < 4;
                string numCheck = check ? "" : "\nINVALID!\n";
                Console.Write(numCheck);
                return (num, check);
            }
            else
            {
                Console.WriteLine("\nINVALID!");
                return (0, false);
            }            

        }

        private static void printUI()
        {
            Users.printLine();
            Console.Write($"\n" +
                $"PASSWORD AUTHENTICATION SYSTEM\n\n" +
                $"[1] Establish an account\n" +
                $"[2] Authenticate a user\n" +
                $"[3] Exit the system\n\n" +
                $"Enter selection: ");            
        }
    }

    public static class Users
    {
        static Dictionary<string, string> _UserPasswords = new Dictionary<string, string>();
        static string _TempUsername = "";
        public static void printUsers()
        {
            Console.WriteLine("ALL USERS\n");

            foreach (var item in _UserPasswords)
            {
                changeColor(ConsoleColor.Cyan);
                Console.Write($"\t{item.Key}");
                Console.ResetColor();
                Console.Write(":");
                changeColor(ConsoleColor.Yellow);
                Console.WriteLine($"\t{item.Value}");
                Console.ResetColor();
            }
        }

        public static void getUser()
        {
            Console.WriteLine("\nAUTHENTICATE USER");

            if (!validateUserName())
            {
                changeColor(ConsoleColor.Red);
                Console.WriteLine("\nINVALID USERNAME!");
                Console.ResetColor();
            }
            else
            {
                if (validatePassword())
                {
                    changeColor(ConsoleColor.Green);
                    Console.WriteLine("\nUser Authenticated!");
                    Console.ResetColor();
                }
                else
                {
                    changeColor(ConsoleColor.Red);
                    Console.WriteLine("\nINVALID PASSWORD!");
                    Console.ResetColor();
                }
            }

        }

        private static void changeColor(ConsoleColor input) => Console.ForegroundColor = input;


        public static void getNewUser()
        {

            Console.Write("\nNEW USER PAGE\n");

            while (validateUserName()) ;

            var passHash = getPassHash();

            _UserPasswords.Add(_TempUsername, passHash);
        }

        private static string getPassHash()
        {
            Console.Write("Input Password: ");
            var input = Console.ReadLine();
            var passHash = makePassHash(input);

            return passHash;

        }

        private static string makePassHash(string input)
        {
            MD5 md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hashBytes = md5.ComputeHash(inputBytes);

            var hash = new StringBuilder();
            foreach (var item in hashBytes) { hash.Append(item.ToString("X2")); }
            return hash.ToString();
        }

        private static bool validateUserName()
        {
            Console.Write("\nInput Username: ");
            _TempUsername = Console.ReadLine();

            return _UserPasswords.ContainsKey(_TempUsername);
        }

        private static bool validatePassword()
        {
            var passHash = getPassHash();

            var realPassHash = _UserPasswords.GetValueOrDefault(_TempUsername);
            return passHash.Equals(realPassHash);
        }

        public static void printLine()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}