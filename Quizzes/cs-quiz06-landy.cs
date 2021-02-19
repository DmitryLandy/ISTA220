/*
 * Name: Dmitry Landy
 * File: cs-quiz06-landy.cs
 * Date: 2/18/2021
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

            gun.message("shoot things");
            shotty.message("go Boom");
            m14.message("go Bang");
            berreta.message("go Pop");
            
        }
        
    }

    class Firearm
    {
        public void message(string weaponAction)
        {
            Console.WriteLine($"I am a {GetType().Name} and I {weaponAction}");
        }
    }
    class Shotgun : Firearm { }
    
    class Rifle : Firearm { }

    class Pistol : Firearm { }

    
}
