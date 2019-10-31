using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_7
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

            DisplayArray(array);
            SortArray(array, GetDiraction());
            DisplayArray(array);
            Console.ReadKey();
        }

        static int ParseInt(string query)
        {
            while (true)
            {
                Console.Write($"Enter {query} : ");
                if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
                {
                    return number;
                }

                Console.WriteLine("Entered string is not a positive number or 0. \n_________________");
            }

        }
        static void DisplayArray(double[] array)
        {
            foreach (double number in array)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("\n");
        }

        static string GetDiraction()
        {
            while (true)
            {
                Console.WriteLine("Enter sort diraction: +(up) or -(down)");
                string direction = Console.ReadLine();
                if (direction == "+" || direction == "-")
                {
                    return direction;
                }
            }
        }
        static void SortArray(double[] array, string direction)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {

                    if (array[j] > array[j + 1])
                    {
                        double temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            if (direction == "-")
            {
                Array.Reverse(array);
            }
        }
    }
}
