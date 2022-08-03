using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers: ");
            int n=int.Parse(Console.ReadLine());

            int[] numbers=new int[n];

            FillNumbers(numbers);
            PrintMaxSumDigits(numbers);
        }

        private static void PrintMaxSumDigits(int[] numbers)
        {
            int index = 0;
            int maxSum = SumOfDigits(numbers[0]);
            for (int i = 1; i < numbers.Length; i++)
            {
                int sum = SumOfDigits(numbers[i]);
                if (sum>maxSum)
                {
                    maxSum = sum;
                    index=i;
                }
            }
            Console.WriteLine($"Number with highest sum is {numbers[index]} => {maxSum}");
        }

        private static int SumOfDigits(int n)
        {
            int sum = 0;
            while (n>0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        private static void FillNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Insert {i + 1} number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
