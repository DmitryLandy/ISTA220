/*
 * Name: Dmitry Landy
 * File: ex10-baseConversion-landy.cs
 * Date: 3/26/2021
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BaseConversion
{
	class Program
	{
		static int _FromBase;
		static int _ToBase;
		static string _NumInput;
		static double _DecimalNum;
		static char[] _HexValues = { 'a', 'b', 'c', 'd', 'e', 'f' };
		static void Main(string[] args)
		{
			Console.Write("---------------------------BASE CONVERSION APPLICATION-----------------------------\n");
			while(true) run();     
		}

		private static void run()
		{
			var selection = promptUser();
			makeSelection(selection);
		}

		private static void makeSelection(string selection)
		{
			selection = selection.Trim().ToLower();
			switch (selection)
			{
				case "help":
					printHelpScreen();
					break;
				case "exit":
					Environment.Exit(0);
					break;
				default:
					if (checkParseInput(selection))//returns true if there is an error while parsing
					{
						printHelpScreen();//go to the help screen due to error						
					}
					else
					{						
						calculateBase(); //calculate the new number						
					}   
				break;
			}
		}

		private static void calculateBase()
		{
			toDecimal();//converts all numbers to decimal first

			if(_ToBase==10)
				Console.WriteLine($"Your Decimal Number is : {_DecimalNum}");
			else if(_ToBase == 2|| _ToBase == 8|| _ToBase == 16)
			{
				Console.WriteLine($"Your base {_ToBase} number is: {toAnyBase()}");
			}
			else
			{
				Console.WriteLine("There was an error!");
				Thread.Sleep(1000);
				printHelpScreen();
			}			
		}

		/// <summary>
		/// Prompts the user for a selection, gets it, and then returns it
		/// </summary>
		private static string promptUser()
		{
			Console.Write("" +
				"Type \"help\", \"exit\" or input the command\n" +
				">> ");
			return Console.ReadLine();
		}
		
		//parses the string to get the number, to base, and from base
		//returns true if there was an error, else returns false
		private static bool checkParseInput(string selection)
		{
			var originalAry = new string[3];
			try
			{
				originalAry = selection.Split(' ');
				_NumInput = originalAry[0]; //could be a hex value with letters
				_FromBase = int.Parse(originalAry[1]);//must be int. From base
				_ToBase = int.Parse(originalAry[2]);//must be int. To base

				return false;
			}
			catch (Exception)
			{
				Console.WriteLine("Invalid Command!");
				return true;
			}
		}

		private static void printHelpScreen()
		{
			Console.Clear();
			Console.WriteLine("" +
				"------------------------------------HELP SCREEN------------------------------------\n" +
				"\tSyntax: [number] [from base] [to base]\n" +
				"\tExample: \"1111 2 16\" will convert 1111 from binary to 0xF hex\n" +
				"\tOptions: 2, 8, 10, 16\n" +
				"\tErrors: If the two words are not ones listed in the options (help or exit)\n" +
				"");            
		}

		//converts number from any base to decimal.
		//loops through the length of the number string
		//
		private static void toDecimal()
		{            
			double sum = 0;            
			int current; //going to hold value of the input number after its normalized
			var numLength = _NumInput.Length;			

			for (int i = 0 ; i< numLength; i++) //loop thorugh the number (string) right to left
			{
				var canConvert = int.TryParse(_NumInput[i].ToString(), out current);
				var exp = numLength - i-1; //exponent is the length - index

				if (!canConvert) //if it isn't a number convert it to one. if it is then parse it and set it to current
				{
					current = convertToDec(_NumInput[i]);
				}  
				sum += current * (Math.Pow(_FromBase, exp)); //(base^counter)* value                     
			}
			_DecimalNum = sum;            
		}


		//Conert hex character to decimal(base10) value
		//returns the int decimal value
		private static int convertToDec(char cNum) => 10+Array.IndexOf(_HexValues, cNum);       

		//This converts from decimal to any other base including hex
		private static string toAnyBase()
		{
			int rem = 0;
			int current = (int)_DecimalNum;
			StringBuilder result = new StringBuilder();
			
			while(current>0)
			{
				rem = current % _ToBase;

				if (rem >= 10)
				{
					result.Insert(0, _HexValues[rem - 10]);
				}
				else
				{
					result.Insert(0, rem);
				}

				current = current / _ToBase;				
			}
			return result.ToString();
		}
	}
}
