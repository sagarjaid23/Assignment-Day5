using System;

namespace odd_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number%2== 0)
            {
                Console.WriteLine("Numer is Even Number");
            }
            else
            {
                Console.WriteLine("Number is Odd Number");
            }
        }
    }
}
