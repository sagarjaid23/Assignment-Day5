using System;

namespace reaminder_and_qu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diviend;
            int divisor;
            int quotient;
            int remainder;

            Console.WriteLine("Please diviend:");
            diviend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter divisor");
            divisor = Convert.ToInt32(Console.ReadLine());

            quotient = diviend / divisor;
            remainder = diviend % divisor;
            
            Console.WriteLine("Quotient=" + quotient);
            Console.WriteLine("Remainer=" +remainder);
            
        }
    }
}
