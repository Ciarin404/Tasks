using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number:");
            string firstString = Console.ReadLine();
            Console.Write("Enter second number:");
            string secondString = Console.ReadLine();
            bool isFirstNumRight = int.TryParse(firstString, out int firstNumber);
            bool isSecondNumRight = int.TryParse(secondString, out int secondNumber);

            if(isFirstNumRight && isSecondNumRight)
            {
                int productOfNumbers = 0;
                if (firstNumber < 0 && secondNumber < 0)
                {
                    firstNumber = -firstNumber;
                    for (int i = 0; i < firstNumber; i++)
                    {
                        productOfNumbers += -secondNumber;
                    }
                    Console.WriteLine($"Product = {productOfNumbers}");
                }
                else if(firstNumber < 0)
                {
                    for (int i = 0; i < secondNumber; i++)
                    {
                        productOfNumbers += firstNumber;
                    }
                    Console.WriteLine($"Product = {productOfNumbers}");
                }
                else if(secondNumber < 0)
                {
                    for (int i = 0; i < firstNumber; i++)
                    {
                        productOfNumbers += secondNumber;
                    }
                    Console.WriteLine($"Product = {productOfNumbers}");
                }
                else
                {
                    for (int i = 0; i < firstNumber; i++)
                    {
                        productOfNumbers += secondNumber;
                    }
                    Console.WriteLine($"Product = {productOfNumbers}");
                }
            }
            else
            {
                Console.WriteLine("Entered strings are not numbers.");
            }
            Console.ReadKey();
        }
    }
}
