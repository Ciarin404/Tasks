using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 3.4;
            double secondNumber = -6.3;
            double thirdNumber = -17.6;
            IncreaseNumber(ref firstNumber, ref secondNumber, ref thirdNumber);
            Console.WriteLine($"{firstNumber} {secondNumber} {thirdNumber}");
            Console.WriteLine($"Radius = {secondNumber}");
            ConsiderCircle(ref secondNumber, out double area, out double length);
            Console.WriteLine($"Area of a circle = {area:0.00}  length of a circle = {length:0.00}");
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

                GetMaxMinAndSummArray(array, out int min, out int max, out int summ);
                Console.WriteLine($"\nMin = {min} , Max = {max} , Summ = {summ}");
            }
            else
            {
                Console.WriteLine("Entered string is not a positive number");
            }

            Console.ReadKey();
        }
        static void IncreaseNumber(ref double first, ref double second, ref double third)
        {
            first += 10;
            second += 10;
            third += 10;
        }
        static void ConsiderCircle(ref double radius, out double area, out double length)
        {
            length = 2 * Math.PI * radius;
            area = Math.PI * Math.Pow(radius, 2);
        }
        static void GetMaxMinAndSummArray(int[] array, out int min, out int max, out int summ)
        {
            min = array.Min();
            max = array.Max();
            summ = array.Sum();
        }
    }
}
