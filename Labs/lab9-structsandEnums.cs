/*
 * Name: Dmitry Landy
 * Lab: lab9-StructsAndEnums-landy.cs
 * Date: 2/10/2021
 */

#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Chapter 9 Lab");

            Month first = Month.January;
            Console.WriteLine(first); //January
            Console.WriteLine((int)first); //index of January
            first++;
            Console.WriteLine(first); //February
            Console.WriteLine((int)first); //index of February
            first += 10;
            Console.WriteLine(first); //December
            Console.WriteLine((int)first); //index of December
            first+=2;
            Console.WriteLine(first); //13 because no more values
            Console.WriteLine((int)first); //13

            Month last = Month.Cesar;
            Console.WriteLine(last); //Cesar
            last++;
            Console.WriteLine((int)last);

            Console.WriteLine("-----------------------");

            Date defaultDate = new Date();
            Console.WriteLine(defaultDate);

            Date weddingAnniversary = new Date(2018, Month.March, 17);
            Console.WriteLine(weddingAnniversary);

            Console.WriteLine("----------------------");
            Date weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine($"Value of copy is {weddingAnniversaryCopy}");

            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"New value of weddingAnniversary is {weddingAnniversary}");
            Console.WriteLine($"Value of copy is still {weddingAnniversaryCopy}");


        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            Console.ReadKey();
        }
        enum Month
        {
            January,    //0
            February,   //1
            March,      //2
            April,      //3
            May,        //4
            June,       //5
            July,       //6
            August,     //7
            September,  //8
            October,    //9
            November,   //10
            December,   //11
            Cesar       //12
        }

        struct Date
        {
            private int year;
            private Month month;
            private int day;

            public Date(int ccyy, Month mm, int dd)
            {
                this.year = ccyy;
                this.month = mm;
                this.day = dd - 1;
            }

            public override string ToString()
            {
                string data = $"{this.month} {this.day + 1}, {this.year}";
                return data;
            }

            public void AdvanceMonth()
            {
                this.month++;
                if (this.month == Month.December + 1)
                {
                    this.month = Month.January;
                    this.year++;
                }

            }

        }
    }
}
