using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintArmstrongsInRange(1, 10000);
        }

        private static void PrintArmstrongsInRange(int from, int to)
        {
            for (int i = from; i <=to ; i++)
            {
                if (IsArmstrongNumber(i))
                {
                    Console.WriteLine($"Number {i} is Armstrong!");
                }
            }
        }

        private static bool IsArmstrongNumber(int n)
        {
            int sum = 0, copy = n;
            while (copy>0)
            {
                sum += (int)Math.Pow(copy % 10, 3);
                copy /= 10;
            }
            return n == sum;
        }
    }
}
