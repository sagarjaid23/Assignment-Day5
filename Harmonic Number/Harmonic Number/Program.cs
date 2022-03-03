using System;

namespace Harmonic_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            HarmonicNumber(number);
        }
        public static void HarmonicNumber(int n)
        {
            double result = 0;
            for (int i = 1; i < n; i++)
            {
                result = (result + 1)/ i;
            }
            Console.WriteLine($"Harmonic Number= {result}");

        }
    }
}
