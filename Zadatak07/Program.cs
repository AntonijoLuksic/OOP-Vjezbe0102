using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TernaryDemo();
            Console.Write("Insert positive number: ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine($"Number {n} is {(IsPerfectNumber(n)?"perfect" :"not perfect")}");
        }

        private static bool IsPerfectNumber(int n)
        {
            int sum = 0;
            for (int i = 1; i <=n/2 ; i++)
            {
                if (n%i==0)
                {
                    sum += i;
                }
            }
            return n == sum;
        }

        private static void TernaryDemo()
        {
            int a=1, b=2;

            Console.WriteLine($"Max: {(a>=b?a:b)} ");
        }
    }
}
