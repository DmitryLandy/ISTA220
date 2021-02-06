/*
 * Name: Dmitry Landy
 * File: progEx04-Landy.cs
 * Date: 2/5/2021
 */
using System;

namespace progEx04
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate 4 cow objects
            Cow spotty = new Cow();
            spotty.name = "Spotty";
            Cow boycow = new Cow("Boycow");
            Cow dolly = new Cow("Dolly");
            Cow jamie = new Cow("Jamie");

            //instantiate duck object
            Duck daffy = new Duck("Daffy");
            Duck diffy = new Duck("Diffy");
            Duck dummy = new Duck("Dummy");
            Duck dobby = new Duck("Dobby");

            //instantiate horse object
            Horse lostHorse = new Horse();
            Horse jimmy = new Horse("Jimmy");
            Horse jerry = new Horse("Jerry");
            Horse junior = new Horse("Junior");

            //instantiate pig object
            Pig drPiggy = new Pig("Dr.Piggy");
            Pig porky = new Pig("Porky");
            Pig peter = new Pig("Peter");
            Pig potter = new Pig("Potter");

            //call methods for objects
            daffy.speak();
            daffy.eat();
            diffy.speak();
            diffy.eat();
            dummy.eat();
            dummy.speak();
            dobby.eat();
            dobby.speak();
            Console.WriteLine();

            lostHorse.speak();
            lostHorse.eat();
            jimmy.speak();
            jimmy.eat();
            jerry.speak();
            jerry.eat();
            junior.speak();
            junior.eat();
            Console.WriteLine();

            drPiggy.speak();
            drPiggy.eat();
            porky.speak();
            porky.eat();
            peter.speak();
            peter.eat();
            potter.speak();
            potter.eat();

            Console.WriteLine("\nThese were the civilized animals....but now here " +
                "are the barbarians!\n" );

            //test methods for each crazy and scary cow
            spotty.eat();
            spotty.speak();
            boycow.eat();
            boycow.speak();
            dolly.eat();
            dolly.speak();
            jamie.eat();
            jamie.speak();

        }
    }

    /// <summary>
    /// This little piggy has a PHD in education. She also loves salads
    /// </summary>
    internal class Pig
    {
        //Name field
        public string name = "";

        //default constructors
        public Pig()
        {
            name = "Unknown";
        }

        //Constructor with one parameter for updating name field
        public Pig(String newName)
        {
            name = newName;
        }

        public void speak()
        {
            Console.WriteLine($"My name is {name} and I go *snort* oink!");
        }

        public void eat()
        {
            Console.WriteLine($"{name}: I eat broccoli *eat salad* ");
        }
    }

    /// <summary>
    /// A very lost horse....where did he come from and who is he?
    /// </summary>
    internal class Horse
    {
        //Name field
        public string name = "";

        //default constructors
        public Horse()
        {
            name = "Unknown";
        }

        //Constructor with one parameter for updating name field
        public Horse(String newName)
        {
            name = newName;
        }

        public void speak()
        {
            if(name.Equals("Unknown"))
                Console.WriteLine($"My name is {name} and I go MEOW...er I mean NEIGH?");
            else
                Console.WriteLine($"My name is {name} and I go  NEIGH!");
        }

        public void eat()
        {
            if(name.Equals("Unknown"))
                Console.WriteLine($"{name}: I eat grass *munch dirt*...dang, I missed it...");
            else
                Console.WriteLine($"{name}: I eat grass *munch grass*");
        }
    }

    /// <summary>
    /// Daffy is just a goofball of a duck.
    /// </summary>
    internal class Duck
    {
        //Name field
        public string name = "";

        //default constructors
        public Duck()
        {
            name = "Unknown";
        }

        //Constructor with one parameter for updating name field
        public Duck(String newName)
        {
            name = newName;
        }

        public void speak()
        {
            Console.WriteLine($"My name is {name} and I go QUACKITY QUACK!");
        }

        public void eat()
        {
            Console.WriteLine($"{name}: I eat ...um....french onion soup? *eat soup* ");
        }
    }

    /// <summary>
    /// These cows are just scary.
    /// </summary>
    internal class Cow
    {
        //Name field
        public string name = "";
        
        //default constructors
        public Cow()
        {
            name = "Unknown";
        }

        //Constructor with one parameter for updating name field
        public Cow(String newName)
        {
            name = newName;
        }

        public void speak()
        {
            Console.WriteLine($"My name is {name} and I go MOOOOO!");
        }

        public void eat()
        {
            Console.WriteLine($"{name}: I eat beef *munch beef* ... what are you looking at?");
        }
    }
}
