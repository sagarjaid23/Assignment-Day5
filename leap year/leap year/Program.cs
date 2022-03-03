using System;

namespace leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Year: ");
            int Year= int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("Year is Leap Year");
            }
            else
            {
                Console.WriteLine("Year is Not Leap Year" );
            }
        }
    }
}
