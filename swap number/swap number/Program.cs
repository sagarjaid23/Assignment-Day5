using System;

namespace swap_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int temp;
            Console.WriteLine("Before Swapping Value of a={0},b={1}", a , b);
           
            temp = a;
            a= b;
            b= temp;
            
            Console.WriteLine("After Swapping Value of a={0},b={1}", a, b);
            
        }
    }
}
