/*
 * Name: Dmitry Landy
 * File: progEx03-landy.cs
 * Date: 1/29/2021
 */
using System;

namespace progeEx03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool errors = true;
            int tracker = 1;

            //loops until there aren't any errors
            while(errors)
            {
                try
                {
                    //picks up on the last method with errors
                    switch(tracker)
                    {
                        case 1:
                            //Part 1: Circumference and area of a circle
                            Console.WriteLine("\nPart 1. circumference and area of a circle.");
                            tracker = circleMethod();
                            break;
                        case 2:
                            //Part 2: Volume of a hemisphere
                            Console.WriteLine("\nPart 2, volume of a hemisphere.");
                            tracker = hemisphereMethod();
                            break;
                        case 3:
                            //Part 3: Area of a triangle
                            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
                            tracker = triangleMethod();
                            break;
                        default:
                            //Part 4: Solving the Quadratic Equation
                            Console.WriteLine("\nPart 4, solving a quadratic equation.");
                            quadraticMethod();
                            errors = false;
                            break;
                    }
                    
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine("You must enter a valid number.");
                    errors = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    errors = true;
                }
                finally
                {
                    Console.WriteLine("Okay.");
                }
            }            
        }

        private static int circleMethod()
        {
            
            Console.Write("Enter an integer for the radius: ");
            string radiusInput = Console.ReadLine();
            int intRadius = int.Parse(radiusInput);

            if (intRadius < 0)
                throw new Exception("Your number is out of range");

            double circumference = 2 * (Math.PI) * intRadius;
            double area = (Math.PI) * (intRadius * intRadius);

            Console.WriteLine($"The circumference is {circumference}");
            Console.WriteLine($"The area is {area}");

            return 2; //signifies method 1 is done
        }

        private static int hemisphereMethod()
        {
            Console.Write("Enter an integer for the radius: ");
            String radiusInput = Console.ReadLine();
            int intRadius = int.Parse(radiusInput);

            if (intRadius < 0)
                throw new Exception("Your number is out of range");

            double volume = ((4 / 3) * (Math.PI) * (intRadius * intRadius * intRadius)) / 2;
            Console.WriteLine($"The volume is {volume})");

            return 3; //signifies method 2 is done
        }

        private static int triangleMethod()
        {
           
            String strVarA, strVarB, strVarC; //holds the input            
            int varA, varB, varC; //holds num of converted string input           

            double varP; //calculate p
            double triangleArea; //calculate triangle area
            
            Console.Write("Enter an integer for side A: ");
            strVarA = Console.ReadLine();
            varA = int.Parse(strVarA);

            if (varA < 0)
                throw new Exception("Your number is out of range");

            Console.Write("Enter an interger for side B: ");
            strVarB = Console.ReadLine();
            varB = int.Parse(strVarB);

            if (varB < 0)
                throw new Exception("Your number is out of range");

            Console.Write("Enter an interger for side C: ");
            strVarC = Console.ReadLine();
            varC = int.Parse(strVarC);

            if (varC < 0)
                throw new Exception("Your number is out of range");

            varP = (varA + varB + varC) / 2; //calculate p
            triangleArea = Math.Sqrt(varP * (varP - varA) * (varP - varB) * (varP - varC));

            Console.WriteLine($"The area is {triangleArea})");

            return 4; //signifies method 3 is done
        }

        private static void quadraticMethod()
        {
            Console.Write("Enter an integer for A: ");
            String strVarA = Console.ReadLine();
            int varA = int.Parse(strVarA);

            Console.Write("Enter an interger for B: ");
            String strVarB = Console.ReadLine();
            int varB = int.Parse(strVarB);

            Console.Write("Enter an interger for C: ");
            String strVarC = Console.ReadLine();
            int varC = int.Parse(strVarC);

            double numPos = (-varB + (Math.Sqrt((varB * varB) - (4 * varA * varC))));
            double numNeg = (-varB - (Math.Sqrt((varB * varB) - (4 * varA * varC))));
            double denom = 2 * varA;

            Console.WriteLine($"The positive solution is {numPos / denom}");
            Console.WriteLine($"The negative solution is {numNeg / denom}");
        }
    }
}
