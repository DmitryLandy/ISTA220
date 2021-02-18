/*
 * Name: Dmitry Landy
 * File: cs-lab12-landy.cs
 * Date: 2/18/2021
 */
using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Test Vehicle");
            Vehicle v = new Vehicle();
            v.StartEngine("RUM RUM");
            v.Drive();
            v.StartEngine("jin jin");

            Console.WriteLine("----------------------------------------------------");


            Console.WriteLine("Journey by airplane:");

            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr");

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Journey by car:");

            Car myCar = new Car();
            myCar.StartEngine("Brm brm"); //from vehicle
            myCar.Accelerate();
            myCar.Drive(); //from vehicle
            myCar.Brake();
            myCar.StopEngine("Phut phut"); //from vehicle

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("\nTesting polymorphism");
            Vehicle w = new Vehicle();
            w.Drive(); //call drive from vehicle
            w = myCar;
            w.Drive(); //call drive from car
            w = myPlane;
            w.Drive(); //call drive from airplane

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Journey by Motorcycle");
            Motorcycle mc = new Motorcycle();
            mc.StartEngine("Hoooooommma");
            mc.Accelerate();
            mc.Drive();
            mc.Brake();
            mc.StopEngine("clunk");



        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
