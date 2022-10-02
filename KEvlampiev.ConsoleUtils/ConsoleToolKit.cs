using System;
using System.Reflection.PortableExecutable;

namespace KEvlampiev.ConsoleUtils
{
    public static class ConsoleToolKit
    {
        public static void DisplayHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(header);
            Console.WriteLine(new string('-', 80));
            Console.ResetColor();
        }

        public static void DisplayError(string errorMessage) 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(errorMessage);
            Console.ResetColor();
        }

    }
}
