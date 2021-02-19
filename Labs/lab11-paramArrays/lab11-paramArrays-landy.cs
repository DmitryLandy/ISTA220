/*
 * Name: Dmitry Landy
 * File: cs-lab11-landy.cs
 * Date: 2/19/2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            //Console.WriteLine(Util.Sum(null));
            //Console.WriteLine(Util.Sum());
            Console.WriteLine(Util.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));
            Console.WriteLine(Util.Sum(33)); //optional
            Console.WriteLine(Util.Sum(23,23)); //optional
            Console.WriteLine(Util.Sum(555,523, 6)); //optional
            Console.WriteLine(Util.Sum(76, 123, 355, 22)); //optional
            Console.WriteLine(Util.Sum(576, 2,3,4,4)); //list
            Console.WriteLine(Util.Sum(3,65,76,7,4,2)); //list
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
