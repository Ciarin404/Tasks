using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Module3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random((int)Stopwatch.GetTimestamp());
            Console.Write("Enter size of array:");
            string stringSize = Console.ReadLine();
            bool isNumber = int.TryParse(stringSize, out int sizeArray);

            if (isNumber && sizeArray > 0)
            {
                var numberArray = new int[sizeArray];

                for (int i = 0; i < numberArray.Length; i++)
                {
                    numberArray[i] = rand.Next(-10, 10);
                    Console.Write($"{numberArray[i]} ");
                }

                Console.Write("\nNumbers are greater than next: ");

                for (int i = 0; i < numberArray.Length - 1; i++)
                {
                    if (numberArray[i] < numberArray[i + 1])
                    {
                        Console.Write($"{numberArray[i + 1]} ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Entered string is not a number or negative.");
            }

            Console.ReadKey();
        }
    }
}
