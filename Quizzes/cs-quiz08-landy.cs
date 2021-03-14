/*
 * Name: Dmitry Landy
 * File: Quiz09-landy.cs
 * Date: 3/11/2021
 */
using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Quiz 9: Generic Collections\n");

            printStack();
            printQueue();
            printDictionary();

        }

        private static void printDictionary()
        {
            Dictionary<String, int> dogDictionary = new Dictionary<string, int>();
            dogDictionary.Add("Labrador", 4);
            dogDictionary.Add("Corgi", 12);
            dogDictionary.Add("German Shepherd", 2);

            Console.WriteLine("\nDictionary (Dog, Age)");
            foreach(KeyValuePair<String, int> kvp in dogDictionary)
                Console.WriteLine(kvp);
        }

        private static void printQueue()
        {
            Queue<String> dogQueue = new Queue<string>();
            dogQueue.Enqueue("Labrador");
            dogQueue.Enqueue("Corgi");
            dogQueue.Enqueue("German Shepherd");

            Console.WriteLine("\nQueue (FIFO): ");
            while(dogQueue.Count>0)
                Console.WriteLine(dogQueue.Dequeue());
        }

        private static void printStack()
        {
            //stack
            Stack<String> dogStack = new Stack<string>();
            dogStack.Push("Labrador");
            dogStack.Push("Corgi");
            dogStack.Push("German Shepherd");

            Console.WriteLine("Stack (LIFO): ");
            while (dogStack.Count > 0)
                Console.WriteLine(dogStack.Pop());
        }
    }
}
