using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterPassing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            PassByValue(i);
            Console.WriteLine($"Value->Main: {i}");

            int j;
            j = 1;
            PassByRef(ref j);
            Console.WriteLine($"Ref->Main: {j}");

            PassByOut(out int k);
            Console.WriteLine($"Out->Main: {k}");

            List<int> list = new List<int>();
            PassbyReference(list);
            Console.WriteLine($"Reference->Main: {list.Count}");
        }

        private static void PassbyReference(List<int> list)
        {
            list.Add(1);
            Console.WriteLine($"Reference->Method: {list.Count}");
        }

        private static void PassByOut(out int k)
        {
            k = 1;
            k++;
            Console.WriteLine($"Out->Method: {k}");
        }

        private static void PassByRef(ref int j)
        {
            j++;
            Console.WriteLine($"Ref->Method: {j}");
        }

        private static void PassByValue(int i)
        {
            i++;
            Console.WriteLine($"Value->Method: {i}");

        }
    }
}
