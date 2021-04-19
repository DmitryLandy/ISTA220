//Name: Dmitry Landy
//Date: 4/12/2021
//File: quiz 22
using System;

namespace quiz22_history
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C# quiz 22");
            Circle a = new Circle(3);
            Console.WriteLine(a);

            Circle b = new Circle(4);
            Console.WriteLine(b);

            Console.WriteLine("New + Operator");
            Console.WriteLine(a+b);

            Console.WriteLine("New - Operator");
            Console.WriteLine(a - b);

            Console.WriteLine("New * Operator");
            Console.WriteLine(a * b);
        }
    }

    internal struct Circle
    {
        public double radius { get; set; }
        public double circumference { get; set; }
        public double area { get; set; }

        public Circle(double rad)
        {
            radius = rad;
            area = Math.PI * (rad * rad); //pi*r^2
            circumference = 2 * Math.PI * rad; //2*pi*r
        }

        private static double toRad(double area) => Math.Sqrt(area / Math.PI);

        public static Circle operator +(Circle a, Circle b) => new Circle(toRad(a.area + b.area));
        public static Circle operator -(Circle a, Circle b) => new Circle(toRad(Math.Abs(a.area - b.area)));
        public static Circle operator *(Circle a, Circle b) => new Circle(toRad(a.area * b.area));



        public override string ToString()
        {
            var printString = $"I am a Circle. My radius is {radius}, my area is {area}, and my circumference" +
                $"is {circumference}";
            return printString;
        }
    }
}
