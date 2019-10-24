using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            var numberString = Console.ReadLine().Replace('.', ',');
            Console.Write("Enter delete numeral:");
            var numeralString = Console.ReadLine();
            bool isNumber = int.TryParse(numberString, out int numberNum);
            bool isNumeral = int.TryParse(numeralString, out int numeralNum);
            int value, count = 0;
            string number1 = default;

            if (isNumber && isNumeral)
            {

                if(numeralNum >= 0)
                {
                    if(numberNum >= 0)
                    {
                        char[] numberArray = numberString.ToCharArray();
                        for (int i = 0; i < numberArray.Length; i++)
                        {
                            value = (int)(numberArray[i] - '0');

                            if (numeralNum == value)
                            {
                                number1 = numberString.Remove(i - count, 1);
                                numberString = number1;
                                count += 1;
                            }
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("Entered strings are not numbers");
            }

            Console.WriteLine($"Number without {numeralNum}: {number1}");
            Console.ReadKey();
        }
    }
}
