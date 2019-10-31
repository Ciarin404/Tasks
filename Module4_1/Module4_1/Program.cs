using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random((int)Stopwatch.GetTimestamp());
            Console.Write("Enter size of array:");
            string stringSize = Console.ReadLine();
            bool isNUmber = int.TryParse(stringSize, out int sizeOfArray) && sizeOfArray > 0;

            if (isNUmber)
            {
                int[] numberArray = new int[sizeOfArray];

                for (int i = 0; i < numberArray.Length; i++)
                {
                    numberArray[i] = rand.Next(-10, 10);
                }

                DisplayArray(numberArray);
                Console.WriteLine($"\nMax = {GetMaxInArray(numberArray)}");
                Console.WriteLine($"Min = {GetMinInArray(numberArray)}");
                Console.WriteLine($"Summ = {GetSummArray(numberArray)}");
                Console.WriteLine($"Substraction max and min = {GetSubstractionMinMax(numberArray)}");
                ModifedArray(numberArray);
                Console.Write("Modifed array: ");
                DisplayArray(numberArray);
            }
            else
            {
                Console.WriteLine("Entered string is not a positive number.");
            }

            Console.ReadKey();
        }
        static int GetMaxInArray(int[] array)
        {
            int max = array[0];

            foreach (int number in array)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }

        static int GetMinInArray(int[] array)
        {
            int min = array[0];

            foreach (var number in array)
            {
                if (number < min)
                {
                    min = number;
                }
            }

            return min;
        }

        static int GetSummArray(int[] array)
        {
            int summ = default;

            foreach (var number in array)
            {
                summ += number;
            }

            return summ;
        }

        static int GetSubstractionMinMax(int[] array)
        {
            int max = GetMaxInArray(array);
            int min = GetMinInArray(array);
            return max - min;
        }

        static void ModifedArray(int[] array)
        {
            int max = GetMaxInArray(array);
            int min = GetMinInArray(array);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[i] += max;
                }
                else
                {
                    if (min < 0)
                    {
                        array[i] += min;
                    }
                    else
                    {
                        array[i] -= min;
                    }
                }
            }
        }

        static void DisplayArray(int[] array)
        {
            foreach (var number in array)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
