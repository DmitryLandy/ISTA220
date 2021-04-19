/*
 * Name: Dmitry Landy
 * File: cs-quiz20-landy.cs
 * Date: 3/30/2021
 */
using System;

namespace quiz20
{
	class Program
	{
		delegate void FirearmDelegate();

		static void Main(string[] args)
		{
			FirearmDelegate fd1 = null;

			var shotgun = new Shotgun();
			var rifle = new Rifle();
			var pistol = new Pistol();

			fd1 += shotgun.message; //add to delegate instance
			fd1 += rifle.message; //add to delegate instance
			fd1 += pistol.message; //add to delegate instance

			fd1(); //call 
		}
	}

	abstract class Firearm
	{
		public String Sound { get; set; }
		public void message()
		{
			Console.WriteLine($"I am a {GetType().Name} and I go {Sound}");
		}
	}
	class Shotgun : Firearm
	{		
		public Shotgun() => Sound = "Boom";		
	}

	class Rifle : Firearm
	{
		public Rifle() => Sound = "Bang";
	}

	class Pistol : Firearm
	{
		public Pistol() => Sound = "Pop";
	}

}