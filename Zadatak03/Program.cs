using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char repeat;

            do
            {
                Console.Clear();

                Console.Write("Insert first number: ");
                double a=double.Parse(Console.ReadLine());

                Console.Write("Insert second number: ");
                double b=double.Parse(Console.ReadLine());

                Console.Write("Insert operation (+,-,*,/): ");

                string op=Console.ReadLine();

                switch (op)
                {
                    case "+":
                        Console.WriteLine($"{a} {op} {b} = {a+b}");
                        break;
                        case "-":
                        Console.WriteLine($"{a} {op} {b} = {a - b}");
                        break;
                    case "*":
                        Console.WriteLine($"{a} {op} {b} = {a - b}");
                        break;
                    case "/":
                        Console.WriteLine($"{a} {op} {b} = {a - b}");
                        break;

                    default:
                        Console.WriteLine("Wrong operation!");
                        break;
                }

                Console.WriteLine("Repeat (y/n)?");

                repeat=Console.ReadKey().KeyChar;
            } while (repeat=='y');
        }
    }
}
