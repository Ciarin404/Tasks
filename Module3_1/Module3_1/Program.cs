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
            var firstNumber = Console.ReadLine();
            Console.Write("Enter second number:");
            var secondNumber = Console.ReadLine();
            bool isFirstNumRight = int.TryParse(firstNumber, out int firstNum);
            bool isSecondNumRight = int.TryParse(secondNumber, out int secondNum);
            int productOfNumbers = 0;

            if(isFirstNumRight && isSecondNumRight)
            {
                if(firstNum < 0 && secondNum < 0)
                {
                    firstNum = -firstNum;
                    for (int i = 0; i < firstNum; i++)
                    {
                        productOfNumbers += -secondNum;
                    }
                    Console.WriteLine($"Product = {productOfNumbers}");
                }
                else if(firstNum < 0)
                {
                    for (int i = 0; i < secondNum; i++)
                    {
                        productOfNumbers += firstNum;
                    }
                    Console.WriteLine($"Product = {productOfNumbers}");
                }
                else if(secondNum < 0)
                {
                    for (int i = 0; i < firstNum; i++)
                    {
                        productOfNumbers += secondNum;
                    }
                    Console.WriteLine($"Product = {productOfNumbers}");
                }
                else
                {
                    for (int i = 0; i < firstNum; i++)
                    {
                        productOfNumbers += secondNum;
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
