/*
 * Name: Dmitry Landy
 * File: cs-ex06-landy.cs
 * Date: 2/20/2021
 * Purpose: This interactive program allows the user to create their own
 * military unit that is composed of multiple parts such as unit name, unit size, types of 
 * personnel and different weapons. In the end there will be a report of the unit
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace MilitaryUnits
{
    class Program
    {
        public static MilitaryUnit u1;
        static void Main(string[] args)
        {
            
            Console.Write("C# Exercise 06: \n\n");

            Console.Write("" +
                "Welcome to the Military Units Creation App!\n" +
                "You can create your own unit and then create a report based on that unit\n" +
                "\nPlease enter your unit name: ");

            string unitName = Console.ReadLine();

            u1 = new MilitaryUnit(unitName);

            Console.WriteLine("State the Unit's Description/History: ");

            u1.addDescription(Console.ReadLine());

            while(true)
                selectAction(menu(true));
           
        }


        private static int menu(bool errors)
        {
            int selectNum = 0;
            do
            {
                Console.Write("\n\nSelect an option below: " +
                "\n1: Add Personnel" +
                "\n2: Add Weapons" +
                "\n3: Print Unit Report" +
                "\n4: Exit the Program" +
                "\n\nOption: ");

                string menuSelect = Console.ReadLine();
                
                (bool err, int num) = checkMenuErrors(menuSelect, 1, 4);
                errors = err;
                selectNum = num;

            } while (errors);

            return selectNum;
        }

        private static (bool, int) checkMenuErrors(string menuSelect, int min, int max)
        {
            try
            {
                int num = int.Parse(menuSelect);
                if (num < min || num > max) throw new Exception();
                return (false, num);
            }
            catch (Exception)
            {
                Console.WriteLine("\nThere was an Error, Please try again\n");
                return (true, 0);
            }

        }
        private static void selectAction(int selected)
        {
            bool errors = true;
            int input = 0;
            switch (selected)
            {
                case 1:
                    //make
                    
                    do (errors, input) = personnelMenu();
                    while (errors);

                    Console.Write("Enter the person's name: ");
                    string name = Console.ReadLine();
                    string rank;

                    switch(input)
                    {
                        case 1: // Officer
                            Console.Write("Enter the rank (O1-O10, W1-W5): ");
                            rank = Console.ReadLine();
                            u1.pList.Add(new Officer(name, rank));
                            break;
                            
                        case 2: //Enlisted
                            Console.Write("Enter the rank (E1-E9): ");
                            rank = Console.ReadLine();
                            u1.pList.Add(new Enlisted(name, rank));
                            break;
                            
                        case 3: //Civilian
                            u1.pList.Add(new Civilian(name));
                            break;
                    }
                    break;
                case 2:
                    do (errors, input) = weaponsMenu();
                    while (errors);

                    switch (input)
                    {
                        case 1:
                            Console.Write("Enter the Small Arms Weapon Name: ");
                            string wName = Console.ReadLine();
                            Console.Write("Enter the calibur (mm): ");
                            float cal = float.Parse(Console.ReadLine());
                            u1.wList.Add(new smallArms(wName, cal));
                            break;
                        case 2:
                            Console.Write("Enter the Artillery Name: ");
                            string aName = Console.ReadLine();
                            Console.Write("Enter the shell size (mm): ");
                            float shell= float.Parse(Console.ReadLine());
                            u1.wList.Add(new smallArms(aName, shell));
                            break;
                        default:
                            break;
                    }

                    
                    break;
                case 3:
                    Console.WriteLine(u1); //calls Military Unit toString() and prints in format
                    break;
                default:
                    Console.WriteLine("\nGOOD-BYE!");
                    Environment.Exit(0);
                    break;
            }
        }

        private static (bool, int) personnelMenu()
        {
            Console.Write("\nChoose personnel type you want to add to your unit:" +
                "\n 1. Officer" +
                "\n 2. Enlisted" +
                "\n 3. Civilian" +
                "\n 4. Back to Menu" +
                "\n\nOption: ");

            String input = Console.ReadLine();
            return checkMenuErrors(input, 1, 4);            
        }
        
        private static (bool, int) weaponsMenu()
        {
            Console.Write("\nChoose weapon type you want to add to your unit:" +
                "\n 1. Small Arms" +
                "\n 2. Artillery" +
                "\n 3. Back to Menu" +
                "\n\nOption: ");

            String input = Console.ReadLine();
            return checkMenuErrors(input, 1, 2);
        }
    }


    class MilitaryUnit
    {
        public string unitName = "Unknown";
        public DateTime dateEst = DateTime.Today;
        public string description = "N/A";

        public List<Personnel> pList = new List<Personnel>();
        public List<Weapon> wList = new List<Weapon>();
        public MilitaryUnit(string name = "Unknown")
        {
            unitName = name;
        }

        public void addDescription(string desc)
        {
            description = desc;
        }

        // Adds a person to the unit. 2 mandatory parameter and 1 optional (rank)
        public void addPersonnel(String type, string name, string rank = "")
        {
            switch (type)
            {
                case "Officer":
                    Officer o = new Officer(name, rank);
                    break;
                case "Enlisted":
                    Enlisted e = new Enlisted(name, rank);
                    break;
                default:
                    Civilian c = new Civilian(name);
                    break;
            }

        }

        public override string ToString()
        {
            string outputStr = $"\n" +
                $"----------------------REPORT----------------------" +
                $"\nUnit Name: {unitName}" +
                $"\nDate Established: {dateEst}" +
                $"\nDescription: {description}" +
                $"\n\n-------------------PERSONNEL COUNT-------------------" +
                $"\nPersonnel Count: {Personnel.persCount}" +
                $"\nOfficer Count: {Officer.officerCount}" +
                $"\nEnlisted Count: {Enlisted.enlistedCount}" +
                $"\nCivilian Count: {Civilian.civCount}" +
                $"\n\n--------------------WEAPONS COUNT--------------------" +
                $"\nWeapons Count: {Weapon.weaponCount}" +
                $"\nSmall Arms Count: {smallArms.smallArmsCount}" +
                $"\nArtillery Count: {artillery.artilleryCount}";

            outputStr += "\n\n--------------------PERSONNEL LIST--------------------";

            foreach (Personnel x in pList)
            {
                outputStr+= "\n"+ x.name;
            }
            outputStr+="\n\n--------------------WEAPONS LIST--------------------";
            //Print list of weapons

            foreach (Weapon x in wList)
            {
                outputStr += "\n"+x.weaponName;
            }


            return outputStr;
        }
    }

    //The Weapon class and subclasses

    class Weapon
    {
        public static int weaponCount = 0;
        public string weaponName = "Unknown";
        public float calibur = 0;

        public Weapon(string name, float cal)
        {
            weaponCount++;
            weaponName = name;
            calibur = cal;
        }

        //virtual methods
        public virtual void load() { }
        public virtual void fire() { }
    }

    class smallArms : Weapon
    {
        bool[] attachements = { false, false, false }; // sight, grip, laser
        public static int smallArmsCount = 0;

        public smallArms(string name, float cal) : base(name, cal) 
        {
            smallArmsCount++;
        }
        
        public override void load()
        {
            Console.WriteLine($"Swaping and Loading Magazine into {weaponName}");
        }

        public override void fire()
        {
            Console.WriteLine("Bang! Bang!");
        }
    }

    class artillery : Weapon
    {
        public static int artilleryCount = 0;
        public artillery(string name, float cal) : base(name, cal)
        {
            artilleryCount++;
        }

        public override void load()
        {
            Console.WriteLine($"Swaping and Loading Artillery shells into {weaponName}");
        }

        public override void fire()
        {
            Console.WriteLine("BOOM! BOOM!");
        }
    }

    //The Personnel class and subclasses

    class Personnel
    {
        public static int persCount = 0; // update total personnel
        public String name = "";

        public Personnel(String n)
        {
            persCount++;
            name = n;
            
        }
    }

    class Soldier : Personnel
    {
        public static int soldierCount = 0;

        public Soldier(string n) : base (n)
        {
            soldierCount++;
        }
    }

    class Officer : Soldier
    {
        public static int officerCount = 0;
        public string rank = "Unknown";

        public Officer(string name, string rank) : base(name)
        {
            officerCount++;
            this.rank = rank;
        }
    }

    class Enlisted : Soldier
    {
        public static int enlistedCount = 0;
        public string rank = "Unknown";

        public Enlisted(string name, string rank) : base(name)
        {
            enlistedCount++;
            this.rank = rank;
        }

    }

    class Civilian : Personnel
    {
        public static int civCount = 0;
        
        public Civilian(string name) : base(name)
        {
            civCount++;
        }

    }
}
