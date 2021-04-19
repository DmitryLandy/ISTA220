//Dmitry Landy
//Exercise 11: Vectors
//4/1/2021
using System;
using System.Collections.Generic;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCISE 11: Vectors\n");
            //createStructure
            var pointList1 = createData(100,1,100);
            var distanceData1 = genDistanceData(pointList1, 2);
            var closestDataSet1 = findClosestSet(distanceData1);
            Console.WriteLine(closestDataSet1);

            var pointList2 = createData(1000, 1, 1000);
            var distanceData2 = genDistanceData(pointList2, 3);
            var closestDataSet2 = findClosestSet(distanceData2);
            Console.WriteLine(closestDataSet2);
        }

        //Finds which data set has the smallest distance property
        private static dataSet findClosestSet(List<dataSet> distanceData)
        {
            double smallestDistance = distanceData[0].distance; 
            dataSet ds = distanceData[0];

           
            foreach (var item in distanceData)
            {                
                if(item.distance<smallestDistance)
                {
                    smallestDistance = item.distance;
                    ds = item;
                }                
            }

            return ds;
        }

        //Computes the Euclidian distance for 2D and 3D points
        private static double computeDistance2D(dataPoint a, dataPoint b) => Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
        private static double computeDistance3D(dataPoint a, dataPoint b) => Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2) + Math.Pow(a.z - b.z, 2));


        //Generates a list of datasets between each pair and their distance
        private static List<dataSet> genDistanceData(List<dataPoint> pointList, int dimensions)
        {
            double distance;
            var distanceList = new List<dataSet>();
            dataSet tempDataSet;
            var passList = new List<dataPoint>();

            for (int i = 0; i < pointList.Count-1; i++)//slow runnern
            {
                for (int j = i+1; j < pointList.Count; j++) //fast runner
                {
                    passList.Add(pointList[i]);
                                        
                    distance = (dimensions == 2) ? computeDistance2D(pointList[i],pointList[j]) : computeDistance3D(pointList[i], pointList[j]);

                    tempDataSet = new dataSet(distance, pointList[i], pointList[j]);
                    tempDataSet.dimensions = dimensions; //necessary to set the dimensions
                    distanceList.Add(tempDataSet);
                }
            }

            return distanceList;
        }

        //Generates the list of points
        private static List<dataPoint> createData(int totalPoints, int min, int max)
        {
            List<dataPoint> pointList = new List<dataPoint>();

            for (int i = 0; i <= totalPoints; i++)
            {
                pointList.Add(new dataPoint(min, max));
            }

            return pointList;
        }
    }

    //Datapoint object consists of coordinate and a printing method to pass the coordinates as strings
    class dataPoint
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        //generates point automatically
        public dataPoint(int start, int end)
        {
            Random rand = new Random();

            x = rand.Next(start, end + 1);
            y = rand.Next(start, end + 1);
            z = rand.Next(start, end + 1);
        }

        public string printPoint(int dimensions)
        {
            var result = (dimensions == 2) ? $"({x},{y})" : $"({x},{y},{z})";
            return result;
        }
    }

    class dataSet
    {
        public dataPoint[] set { get; set; } //holds two points
        public double distance { get; set; }//distance between the two points
        public int dimensions { get; set; }

        public dataSet(double distance, params dataPoint[] set)
        {
            this.set = set;
            this.distance = distance;
        }

        public override string ToString()
        {
            var printStatement = $"The closest points are: {set[0].printPoint(dimensions)}, {set[1].printPoint(dimensions)} with a distance of {distance}";

            return printStatement;
        }
    }
}
