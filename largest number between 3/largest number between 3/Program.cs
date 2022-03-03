using System;

namespace largest_number_between_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string result;
            Console.WriteLine("First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1>num2)
            {
                result = "The First Number is Greatest Number \n";
            }
            else if (num2 > num1 && num2 > num3)
            {
                result = "The Second Number is Greatest Number \n";
            }
            else
            {
                result = "The Third Number is Greatest Number \n";
            }
            Console.WriteLine(result);

        }
    }
}
