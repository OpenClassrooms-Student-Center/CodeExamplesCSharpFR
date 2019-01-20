using System;
using MultiMessages;

namespace MainArguments
{
    /// <summary>
    /// Demo program for Part 2, Chapter 1, Section 3
    /// </summary>
    class Program
    {   
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            MultiMessages.Messages.PrintCasualWelcome(args[0]);
        }
    }
}
