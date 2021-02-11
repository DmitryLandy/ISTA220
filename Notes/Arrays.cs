using System;

namespace aryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aryName = { 11, 212, 33, 423, 5, 64, 723, 823, 923, 02 };

            for(int i  = 0; i < aryName.Length; i++)
            {
                if (i == 2)
                    aryName[i] = 64;
                Console.WriteLine($"{i}: {aryName[i]}");
            }

            Console.WriteLine("\n\n");

            //de-references pointer and returns the value
            foreach (int e  in aryName)
            {
                //if (e == 11) e = 64; can't do this.
                Console.WriteLine(e);
            }
        }
    }
}
