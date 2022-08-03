using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintPrimesInRange(1, 100);
        }

        private static void PrintPrimesInRange(int from, int to)
        {
            for (int i = from; i <=to ; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.WriteLine($"Number {i} is prime.");
                }
            }
        }

        private static bool IsPrimeNumber(int n)
        {
            for (int i = 2; i <=n/2 ; i++)
            {
                if (n%i==0)
                {
                    return false;
                }
            }
            return n != 1;
        }
    }
}
