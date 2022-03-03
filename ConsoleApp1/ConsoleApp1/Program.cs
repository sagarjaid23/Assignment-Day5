using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number:");
            int number=Convert.ToInt32(Console.ReadLine());

            Flipcoin f = new Flipcoin();
            f.FlipCoinMethod(number);
        }
    }
}
