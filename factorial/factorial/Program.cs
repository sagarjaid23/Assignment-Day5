using System;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Factor(number);
        }
        public static void Factor(int n)
        {
            int result = 1;
            while(n!=0)
            {
                result *= n;
                n--;
            }
            Console.WriteLine($"Result is={result}");
        }
    }
}
