using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Increase(4, 2, -8));
            (double area, double length) circle = FindAreaAndLength(4);
            Console.WriteLine("Radius = 4");
            Console.WriteLine($"Area of a circle = {circle.area:0.00}  Length of a circle = {circle.length:0.00}");
            var rand = new Random((int)Stopwatch.GetTimestamp());
            Console.Write("Enter size of array:");
            bool isNumber = int.TryParse(Console.ReadLine(), out int sizeOfArray) && sizeOfArray > 0;
            int[] array = new int[sizeOfArray];
            if (isNumber)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(-10, 10);
                    Console.Write($"{array[i]} ");
                }

                (int max, int min, int summ) tupleArray = FindMaxMinAndSumm(array);
                Console.WriteLine($"\nMax = {tupleArray.max} Min = {tupleArray.min} Summ = {tupleArray.summ}");
            }
            else
            {
                Console.WriteLine("Entered string is not a positive number");
            }

            Console.ReadKey();
        }
        private static (int, int, int) Increase(int first, int second, int third)
        {
            return (first + 10, second + 10, third + 10);
        }
        private static (double area, double length) FindAreaAndLength(int radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            double length = 2 * Math.PI * radius;
            return (area, length);
        }
        private static (int max, int min, int summ) FindMaxMinAndSumm(int[] array)
        {
            int max = array.Max();
            int min = array.Min();
            int summ = array.Sum();
            return (max, min, summ);
        }
    }
}
