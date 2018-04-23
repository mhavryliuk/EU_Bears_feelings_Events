using System;

namespace _20180320_Task1_Events
{
    public delegate void EventDelegate();

    class Subject
    {
        // 2. Declaring Flirt and Run Events.
        public event EventDelegate BeginningOfFlirting = null;

        // 5. A method that signals the start of an event.
        public void FlirtEvent()
        {
            if (BeginningOfFlirting != null)
            {
                Console.WriteLine("Rose publicly announced her choice...\n");
                BeginningOfFlirting.Invoke();
            }
        }
    }

    class Program
    {
        // 6. Methods of event handlers.
        static private void Flirt_Handler()
        {
            Console.WriteLine("Jack now meets Rose.");
        }

        static private void Run_Handler()
        {
            Console.WriteLine("Billy was upset and ran away...");
        }

        static void Main()
        {
            // 1. Create a publisher.
            Subject Rose = new Subject();

            // 3. Attaching event handlers.
            Rose.BeginningOfFlirting += Flirt_Handler;
            Rose.BeginningOfFlirting += Run_Handler;

            // 4. Run the event handler method.
            Rose.FlirtEvent();

            // 7. Rose doesn't communicate with Billy anymore.
            Console.WriteLine("\nRose doesn't communicate with Billy anymore.");
            Rose.BeginningOfFlirting -= Run_Handler;

            Console.ReadKey();
        }
    }
}