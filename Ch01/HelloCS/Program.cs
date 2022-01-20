using System;

namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello, .Net 5.0!");
            Console.ResetColor ();
        }
    }
}
