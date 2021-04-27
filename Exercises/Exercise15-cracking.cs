//Dmitry Landy
//Date: 4/26/2021
//Lab: Ex 15-cracking
using System;
using System.Diagnostics;

namespace ex15_bruteforce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 15-Cracking");
            var password = "P3+";
            Cracker crack1 = new Cracker(password.Length);
            Cracker crack2 = new Cracker(password.Length);
            Stopwatch sw = new Stopwatch();

            sw.Start();
            Console.WriteLine(crack1.singleThread(password));
            sw.Stop();
            Console.WriteLine($"Single Threading Time in Milliseconds: {sw.ElapsedMilliseconds}");

            sw.Restart();

            sw.Start();
            Console.WriteLine(   crack2.multiThread(password));
            sw.Stop();

            Console.WriteLine($"Multi-threading Time in Milliseconds: {sw.ElapsedMilliseconds}");



        }
    }
    class Cracker
    {

        private List<List<char>> aryOfAllLetters = new List<List<char>>();
        private int totalLetters;
        private int passwordLength;

        public Cracker(int passLength)
        {
            var allChars = new List<char>();

            for (int i = 32; i < 127; i++)
            {
                allChars.Add((char)i);
            }

            for (int i = 0; i < passLength; i++)
            {
                aryOfAllLetters.Add(allChars);
            }
            totalLetters = allChars.Count;
            passwordLength = passLength;
        }

        public string singleThread(string password)
        {
            //list of char []
            var permutations = new List<string>();

            //set up perms
            setupPerms(permutations);

            if (aryOfAllLetters.Count > 1)
            {
                fillPerms(permutations);
            }

            return permutations.First(p => p.Equals(password));
        }

        private void setupPerms(List<string> permutations)
        {
            for (int i = 0; i < aryOfAllLetters[0].Count; i++) // Loops through first list
            {
                char currentLetter = aryOfAllLetters[0][i]; //specific letter
                //create starts for combinations
                for (int x = 0; x < Math.Pow(aryOfAllLetters[0].Count, aryOfAllLetters.Count - 1); x++)
                {
                    permutations.Add(currentLetter.ToString());
                }
            }
        }


        private void fillPerms(List<string> permutations)
        {
            char currentLetter;
            double iterations;
            int index = 0;

            for (int i = 1; i < aryOfAllLetters.Count; i++) // loop through lists after 1
            {
                for (int perm = 0; perm < permutations.Count; perm++) //loop through permutations list
                {
                    //how many times the letter needs to be kept before changing
                    iterations = Math.Pow(totalLetters, passwordLength - i - 1);

                    if (perm % iterations == 0 && perm != 0) index++;
                    if (index == totalLetters) index = 0;
                    currentLetter = aryOfAllLetters[i][index];
                    permutations[perm] += currentLetter;
                }
                index = 0;
            }
        }



        public string multiThread(string password)
        {
            //list of char []
            var permutations = new List<string>();

            //set up perms
            setupPerms2(permutations);

            if (aryOfAllLetters.Count > 1)
            {
                fillPerms2(permutations);
            }

            return permutations.First(p => p.Equals(password));
        }
        private void setupPerms2(List<string> permutations)
        {
            for (int i = 0; i < aryOfAllLetters[0].Count; i++) // Loops through first list
            {
                char currentLetter = aryOfAllLetters[0][i]; //specific letter
                //create starts for combinations
                Parallel.For(0, (int)Math.Pow(aryOfAllLetters[0].Count, aryOfAllLetters.Count - 1) - 1, x =>
                {
                    permutations.Add(currentLetter.ToString());
                });
            }
        }

        private void fillPerms2(List<string> permutations)
        {
            char currentLetter;
            double iterations;
            int index = 0;

            for (int i = 1; i < aryOfAllLetters.Count; i++) // loop through lists after 1
            {
                for (int perm = 0; perm < permutations.Count; perm++) //loop through permutations list
                {
                    //how many times the letter needs to be kept before changing
                    iterations = Math.Pow(totalLetters, passwordLength - i - 1);

                    if (perm % iterations == 0 && perm != 0) index++;
                    if (index == totalLetters) index = 0;
                    currentLetter = aryOfAllLetters[i][index];
                    permutations[perm] += currentLetter;
                }
                index = 0;
            }
        }


    }
}
