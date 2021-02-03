/*
 * Name: Dmitry Landy
 * File: Lab07-point-landy.cs
 * Date: 2/3/2021
 */

#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int _x = 0, _y = 0, _z = 0; //instance variable
        private int serialNumber;

        private static int objectCount = 0; //class variable


        public static int ObjectCount()
        {
            return objectCount;
        }
        public Point()
        {
            _x = -1;
            _y = -1;
            objectCount++;
            serialNumber = objectCount;
            Console.WriteLine($"Default constructor called, point number {serialNumber}");
        }
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
            objectCount++;
            serialNumber = objectCount;
            Console.WriteLine($"x:{x}, y:{y}, point number {serialNumber}");
        }

        public Point(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
            objectCount++;
            serialNumber = objectCount;

            Console.WriteLine($"x:{_x}, y:{_y}, z:{_z}, point number {serialNumber}");
        }
        public double DistanceTo(Point other) //other contains address that points the memory location on the heap
        {
            int xDiff = _x - other._x;
            int yDiff = _y - other._y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;

        }

        public double DistanceToTriple(Point other) //other contains address that points the memory location on the heap
        {
            int xDiff = _x - other._x;
            int yDiff = _y - other._y;
            int zDiff = _z - other._z;
            double distance = 
                Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff) + (zDiff*zDiff));
            return distance;

        }
    }
}
