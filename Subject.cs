using System;

namespace _20180320_Task1_Events
{
    internal class Subject
    {
        /// <summary>
        /// Declaring Flirt and Run Events.
        /// </summary>
        public event EventDelegate BeginningOfFlirting = null;

        /// <summary>
        /// A method that signals the start of an event.
        /// </summary>
        public void FlirtEvent()
        {
            if (BeginningOfFlirting != null)
            {
                Console.WriteLine("Rose publicly announced her choice...\n");
                BeginningOfFlirting.Invoke();
            }
        }
    }
}