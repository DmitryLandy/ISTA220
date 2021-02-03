using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point();
            Point bottomRight = new Point(1366, 768);
            Point bottomRight2 = new Point(1366, 768, 33);
            Point point1 = new Point(0, 0);
            Point point2 = new Point(3, 4);
            Point threePoint1 = new Point(5, 5, 6);
            Point threePoint2 = new Point(3, 2, 1);
            //Example of message passing
            Console.WriteLine($"Distance between point 1 and point 2 is:" +
                $" {point1.DistanceTo(point2)}");

            Console.WriteLine($"Distance between point 2 and point 1 is:" +
                $" {point2.DistanceTo(point1)}");

            Console.WriteLine($"Distance between point 2 and point 1 is:" +
                $" {point1.DistanceTo(point1)}");

            Console.WriteLine($"Distance between threePoint1 and threePoint2 is" +
                $" {threePoint1.DistanceToTriple(threePoint2)}");
            
            Console.WriteLine($"The number of points created is: " +
                $"{Point.ObjectCount()}");
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
        }
    }
}
