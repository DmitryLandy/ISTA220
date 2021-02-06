/*
 * Name: Dmitry Landy
 * File: cs-quiz04-landy.cs
 * Date: 2/4/2021
 */
using System;

namespace projEx4
{
    class Program
    {
        static void Main(string[] args)
        {
			Firearm shotgun = new Firearm();
			Firearm rifle = new Firearm();
			Firearm pistol = new Firearm();

			shotgun.message("shotgun");
			rifle.message("rifle");
			pistol.message("pistol");
		}
    }
}

class Firearm
{
	public void message(String weapon)
	{
		String sound = "";
		switch (weapon)
		{
			case "shotgun":
				sound = "Boom";
				break;
			case "rifle":
				sound = "Bang";
				break;
			default:
				sound = "Pop";
				break;
		}

        Console.WriteLine($"I am a {weapon} and I go {sound}");
	}

}

