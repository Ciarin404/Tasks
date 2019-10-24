using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            var enteredNumber = Console.ReadLine();
            bool isNumber = int.TryParse(enteredNumber, out int numberNum);

            if(isNumber && numberNum > 0)
            {
                int[] fibArray = new int[numberNum + 1];

                for (int i = 0; i <= numberNum ; i++)
                {
                    if(i == 0)
                    {
                        fibArray[i] = 0;
                        Console.Write($"{fibArray[0]} ");
                    }
                    else if(i == 1)
                    {
                        fibArray[i] = 1;
                        Console.Write($"{fibArray[i]} ");
                    }
                    else
                    {
                        fibArray[i] = fibArray[i - 2] + fibArray[i - 1];
                        Console.Write($"{fibArray[i]} ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Entered string is not a number or it is negative.");
            }

            Console.ReadKey();
        }
    }
}
