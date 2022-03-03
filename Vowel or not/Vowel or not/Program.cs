using System;

namespace Vowel_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter Alphabet");
            s = Console.ReadLine();
           

            switch (s)
            {
                case "a": Console.WriteLine("Vowel"); break;
                case "e": Console.WriteLine("Vowel"); break;
                case "i": Console.WriteLine("Vowel"); break;
                case "o": Console.WriteLine("Vowel"); break;
                case "u": Console.WriteLine("Vowel"); break;
                case "A": Console.WriteLine("Vowel"); break;
                case "E": Console.WriteLine("Vowel"); break;
                case "I": Console.WriteLine("Vowel"); break;
                case "O": Console.WriteLine("Vowel"); break;
                case "U": Console.WriteLine("Vowel"); break;
                default:
                    Console.WriteLine("Alphabet is Consonent"); break;
                    
            }
        }
    }
}
