using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Module3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random((int)Stopwatch.GetTimestamp());
            Console.Write("Enter size of Array:");
            var stringSize = Console.ReadLine();
            bool isNumber = int.TryParse(stringSize, out int sizeArray);
            var numberArray = new int[sizeArray];

            if (isNumber)
            {
                for (int i = 0; i < numberArray.Length; i++)
                {
                    numberArray[i] = rand.Next(-10, 10);
                    Console.Write($"{numberArray[i]} ");
                }

                Console.WriteLine("\nArray after conversion.");

                for (int i = 0; i < numberArray.Length; i++)
                {
                    numberArray[i] = -numberArray[i];
                    Console.Write($"{numberArray[i]} ");
                }
            }
            else
            {
                Console.WriteLine("Entered string is not a number.");
            }

            Console.ReadKey();
        }
    }
}
