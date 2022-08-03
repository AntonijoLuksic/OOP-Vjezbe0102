using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = ReadString("Student first name:");
            string lastName = ReadString("Student last name:");

            int n = ReadInt("Insert number of grades: ");
            int[] grades = new int[n];

            InsertGrades(grades);
            PrintScore(firstName, lastName, grades);

        }

        private static void PrintScore(string firstName, string lastName, int[] grades)
        {
            double sum = 0;
            foreach (var grade in grades)
            {
                if (grade==1)
                {
                    Console.WriteLine("Student has failed");
                    return;
                }
                sum += grade;
            }
            Console.WriteLine($"Average score for student {firstName} {lastName} is {sum/grades.Length}");
        }

        private static void InsertGrades(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = ReadIntInRange($"Insert {i + 1} grade: ", 1, 5);
            }
        }

        private static int ReadIntInRange(string message, int min, int max)
        {
            int n;
            do
            {
                n = ReadInt(message);
            } while (n<min||n>max);
            return n;
        }

        private static int ReadInt(string message)
        {
            int n;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(),out n));
            return n;
        }

        private static string ReadString(string message)
        {
            string s;
            do
            {
                Console.WriteLine(message);
                s=Console.ReadLine().Trim();
            } while (string.IsNullOrWhiteSpace(s));
            return s;
        }
    }
}
