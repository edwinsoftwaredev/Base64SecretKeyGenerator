using System;
using System.Threading;

namespace Base64SecretKeyGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Base64 Secret key Generator";
            var key = Base64SecretKeyProvider.GetKey(128);
            Console.Beep();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("");
            
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Welcome to the Base64 Secret Generator!\n");

            Console.WriteLine("Generating a Base64 secret key...\n");

            Thread.Sleep(3000);

            Console.WriteLine("This is your key: \n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(key);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThank you for use this service.\n\nSee you later.");

            Console.WriteLine("*****************************************************************************");

            Console.ReadKey(false);
        }
    }
}