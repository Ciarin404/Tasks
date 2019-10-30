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
            string enteredNumber = Console.ReadLine();
            bool isNumber = int.TryParse(enteredNumber, out int numberNum);

            if (isNumber && numberNum > 0)
            {
                int[] fibArray = new int[numberNum];
                if (numberNum == 1)
                {
                    fibArray[0] = 0;
                }
                else
                {
                    fibArray[0] = 0;
                    fibArray[1] = 1;
                }
                for (int i = 2; i < numberNum; i++)
                {
                    fibArray[i] = fibArray[i - 2] + fibArray[i - 1];
                }

                for (int i = 0; i < fibArray.Length; i++)
                {
                    Console.Write($"{fibArray[i]} ");
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
