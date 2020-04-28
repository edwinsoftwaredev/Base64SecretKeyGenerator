using System;
using System.Security.Cryptography;

namespace Base64SecretKeyGenerator
{
    public static class Base64SecretKeyProvider
    {
        public static string GetKey(int numberOfBytes)
        {
            var provider = new RNGCryptoServiceProvider();
            
            var inputBytes = new byte[numberOfBytes];
            provider.GetBytes(inputBytes);
            
            /*
                var compareInput = 
                 Convert.FromBase64String(Convert.ToBase64String(inputBytes, Base64FormattingOptions.None));
            */

            // https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sequenceequal?view=netcore-3.1
            /*
                 if (inputBytes.SequenceEqual(compareInput))
                {
                    Console.WriteLine("\n");
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Arrays are equal!!");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n");
                }
            */
            
            return Convert.ToBase64String(inputBytes, Base64FormattingOptions.InsertLineBreaks);
        }
    }
}