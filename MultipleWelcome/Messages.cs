using System;
namespace MultiMessages
{
    public static class Messages
    {
        /// <summary>
        /// Prints a regular welcome message.
        /// </summary>
        /// <param name="recipient">Recipient.</param>
        public static void PrintRegularWelcome(string recipient)
        {
            Console.WriteLine($"Bonjour, {recipient}!");
        }

        /// <summary>
        /// Prints a casual welcome message.
        /// </summary>
        /// <param name="recipient">Recipient.</param>
        public static void PrintCasualWelcome(string recipient)
        {
            Console.WriteLine($"Content de te voir, {recipient}!");
        }

        /// <summary>
        /// Prints a formal welcome message.
        /// </summary>
        /// <param name="recipient">Recipient.</param>
        public static void PrintFormalWelcome(string recipient)
        {
            Console.WriteLine($"Toutes nos chaleureuses salutations, {recipient}!");
        }
    }
}
