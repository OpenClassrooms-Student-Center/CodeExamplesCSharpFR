using System;

namespace MultiMessages
{
    class Program
    {
        public static void Main(string[] args)
        {
            Messages.PrintRegularWelcome("monde");
            Messages.PrintCasualWelcome("toi");
            Messages.PrintFormalWelcome("Monseigneur");
        }
    }
}
