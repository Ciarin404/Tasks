using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            var number = Console.ReadLine().Replace('.', ',');
            bool isNumber = double.TryParse(number, out double numberNum);
            char[] numberArray;

            if (isNumber)
            {
                if (numberNum >= 0)
                {
                    numberArray = number.ToCharArray();
                    Array.Reverse(numberArray);
                    number = new string(numberArray);
                    numberNum = double.Parse(number);
                    Console.Write($"Reverse number: {numberNum}");
                }
                else
                {
                    numberNum = -numberNum;
                    numberArray = number.ToCharArray();
                    Array.Reverse(numberArray);
                    number = new string(numberArray);
                    numberNum = double.Parse(number);
                    Console.Write($"Reverse number: {-numberNum}");
                }
            }
            else
            {
                Console.WriteLine("Entered string is not a number");
            }

            Console.ReadKey();
        }
    }
}
