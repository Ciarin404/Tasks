using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random((int)Stopwatch.GetTimestamp());
            int sizeOfArray = ParseInt("size of array");
            double[] array = new double[sizeOfArray];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
            }

            Console.Write("Original array: ");
            DisplayArray(array);
            IncreaseElementsOfArray(array);
            Console.Write("Modifited array: ");
            DisplayArray(array);
            Console.ReadKey();
        }

        static int ParseInt(string query)
        {
            Console.Write($"Enter {query}: ");

            while (true)
            {

                if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
                {
                    return number;
                }

                Console.WriteLine("Entered string is not a positive number or 0.\n________________________");
            }
        }

        static void IncreaseElementsOfArray(double[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }

        }
        static void DisplayArray(double[] array)
        {

            foreach (var number in array)
            {
                Console.Write($"{number} ");
            }

            Console.Write($"\n");

        }
    }
}
