using System;

namespace _20180320_Task1_Events
{
    public delegate void EventDelegate();

    internal class Program
    {
        /// <summary>
        /// First method of event handler.
        /// </summary>
        private static void Flirt_Handler()
        {
            Console.WriteLine("Jack now meets Rose.");
        }

        /// <summary>
        /// Second method of event handler.
        /// </summary>
        private static void Run_Handler()
        {
            Console.WriteLine("Billy was upset and ran away...");
        }

        private static void Main()
        {
            
            Subject Rose = new Subject();   // Create a publisher.

            Rose.BeginningOfFlirting += Flirt_Handler;
            Rose.BeginningOfFlirting += Run_Handler;

            Rose.FlirtEvent();              // Run the event handler method.

            Console.WriteLine("\nRose doesn't communicate with Billy anymore.");
            Rose.BeginningOfFlirting -= Run_Handler;

            Console.ReadKey();
        }
    }
}