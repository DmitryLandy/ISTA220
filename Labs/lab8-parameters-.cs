/*
 * Name: Dmitry Landy
 * File: lab08-params-landy
 * Date: 2/4/2021
 */
#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int i = 0;
            Console.WriteLine(i);
            Pass.Value(i);
            Console.WriteLine(i);
            i = Pass.setI(); //run setI
            Console.WriteLine(i); //sets it to 99

            Console.WriteLine("-----------------");

            int x = 0;
            Console.WriteLine($"x is {x}");
            Pass.Value2(ref x);
            Console.WriteLine(x);


            Console.WriteLine("----------------");


            WrappedInt wi = new WrappedInt(); //create WrappedInt object
            Console.WriteLine(wi.Number); //prints number property, which isn't init'd
            Pass.Reference(wi); //assigns the Number property of wi object
            Console.WriteLine(wi.Number);

            Console.WriteLine(wi.Boomer);
            Pass.Reference2(wi); //assigns the boomer property of wi object
            Console.WriteLine(wi.Boomer);

            Console.WriteLine(wi.isTrue);
            Pass.Reference3(wi); //assigns the isTrue property of wi object
            Console.WriteLine(wi.isTrue);

            Duck daffy = new Duck();
            Console.WriteLine($"daffy's name is [{daffy.Name}]");
            daffy.Name = "Daffy"; //updates the Name property of daffy to "Daffy"
            Console.WriteLine($"daffy's name is [{daffy.Name}]");

            daffy.setName("Daffidil"); //Uses setName() to update Name property
            Console.WriteLine($"Daffy's name is now {daffy.Name}");

            Duck hewie = new Duck();
            hewie.setName("Hewie"); //updates name field of hewie instance via the setName()
            Console.WriteLine(hewie.Name);

        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey(); //keeps the output window open
        }
    }

    internal class Duck
    {
        //field
        internal string Name;

        internal void setName(string name)
        {
            Name = name;
        }
    }
}
