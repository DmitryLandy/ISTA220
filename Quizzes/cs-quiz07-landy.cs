/*
 * Name: Dmitry Landy
 * File: cs-quiz07-landy.cs
 * Date: 2/24/2021
 */
using System;

namespace quiz06
{
    class Program
    {
        static void Main(string[] args)
        {
            Firearm gun = new Firearm();
            Shotgun shotty = new Shotgun();
            Rifle m14 = new Rifle();
            Pistol berreta = new Pistol();

            //gun.message("shoot things");
            //shotty.message("go boom!");
            //m14.message("go bang");
            //berreta.message("go pop");
        }
    }

    interface IFirearm
    {
        public void message(string m);
    }

    class Firearm : IFirearm
    {
        public void message(string m)
        {
            Console.WriteLine($"I am a {GetType().Name} and I {m}");
        }
    }
    class Shotgun : Firearm { }

    
    class Rifle : Firearm { }
    

   class Pistol : Firearm { }    
}
