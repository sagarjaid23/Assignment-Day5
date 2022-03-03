using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Flipcoin
    {
        int head = 0;
        int tail = 0;
        public void FlipCoinMethod(int input)
        {
            int temp = input;
            Random random = new Random();
              
            while(input!=0)
            {
             double Random=random.NextDouble();
              if (Random <= 0.5)
                {
                    tail = tail + 1;
                }
              else
                {
                    head = head + 1;

                }
              input=input+1;
            }
            Console.WriteLine((head * 100) / temp);
            Console.WriteLine((tail * 100) / temp);
        }

    }
}
