using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert positive number: ");
            int n=int.Parse(Console.ReadLine());
            long factorial = Factorial(n);
            Console.WriteLine($"{n}!= {factorial}");
        }

        private static long Factorial(int n)
        {
            if (n<=1)
            {
                return 1; //bazni slucaj koji prekida rekurzivno pozivanje metode
            }
            return n * Factorial(--n); //rekurzija
        }
    }
}
