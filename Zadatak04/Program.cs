using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert year: ");
            int year=int.Parse(Console.ReadLine());

            if ((year%4==0&&year%100!=0)||year%400==0)
            {
                Console.WriteLine("Year is leap");
            }
            else
            {
                Console.WriteLine("Year is common");
            }
        }
    }
}
