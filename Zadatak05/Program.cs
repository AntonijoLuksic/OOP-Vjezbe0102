using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WhileDemo();
            ForDemo();
            DoWhileDemo();
        }

        private static void DoWhileDemo()
        {
            int i = 1, sum = 0;

            do
            {
                sum += i++;
            } while (i<=100);
            Console.WriteLine($"Sum of first {--i} numbers: {sum}");
        }

        private static void ForDemo()
        {
            int i=0, sum=0;
            for (;  i<=100; )
            {
                sum += i++;
            }
            Console.WriteLine($"Sum of first {--i} numbers: {sum}");
        }

        private static void WhileDemo()
        {
            int i=0, sum=0;
            while(i<=100)
            {
                sum += i++;
            }

            Console.WriteLine($"Sum of first {--i} numbers: {sum}");
        }
    }
}
