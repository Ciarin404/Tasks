using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number:");
            var enteredNumber = Console.ReadLine();
            bool numRight = int.TryParse(enteredNumber, out int numberNum);
            if (numRight)
            {
                if (numberNum < 0)
                {
                        Console.Write($"Entered number is negative.");
                }
                else if(numberNum > 0)
                {
                    for (int i = 0; i < numberNum; i++)
                    {
                        Console.Write($"{i * 2} ");
                    }
                }
                else
                {
                    Console.WriteLine("Entered 0");
                }
            }
            else
            {
                Console.WriteLine("Entered string is not number.");
            }
            Console.ReadKey();
        }
    }
}
