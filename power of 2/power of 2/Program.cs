using System;

namespace power_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            power_of_2(number);
        }
        public static void power_of_2(int n)
        {
            int result = 1;
            while(n!=0)
            {
                result *= 2;
                n--;
            }
            Console.WriteLine(result);
        }
    }

    
}
