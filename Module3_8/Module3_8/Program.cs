using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter left bound:");
            bool isLeftNumber = double.TryParse(Console.ReadLine(), out double leftBound);
            Console.Write("Enter right bound:");
            bool isRightNumber = double.TryParse(Console.ReadLine(), out double rightBound);
            Console.Write("Enter accuracy:");
            bool isAccNumber = double.TryParse(Console.ReadLine(), out double accuracy);
            double solution = default;

            if (isLeftNumber && isRightNumber && isAccNumber)
            {
                while (Math.Abs(rightBound - leftBound) > accuracy)
                {
                    solution = (leftBound + rightBound) / 2;
                    if (Function(leftBound) * Function(solution) < 0)
                    {
                        rightBound = solution;
                    }

                    if (Function(rightBound) * Function(solution) < 0)
                    {
                        leftBound = solution;
                    }
                }

                solution = leftBound - rightBound;
                Console.WriteLine($"Solution: x = {solution}");
            }
            else
            {
                Console.WriteLine("Entered strings are not numbers");
            }
            int sizeArray = default;
            while (true)
            {
                Console.Write("Enter size of array:");
                if(int.TryParse(Console.ReadLine(), out sizeArray) && (sizeArray > 0) && (sizeArray < 30))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entered string is not a number or in a non-range (0-30).");
                }
            }
            var array = new int[sizeArray, sizeArray];
            int left = 0, right = sizeArray - 1, top = 0, bottom = sizeArray - 1;
            var counter = 1;
            while ((left <= right) || (top < bottom))
            {
                for (var i = left; i <= right; i++)
                {
                    array[i, top] = counter++;
                }
                top++;
                for (var i = top; i <= bottom; i++)
                {
                    array[right, i] = counter++;
                }
                right--;
                for (var i = right; i >= left; i--)
                {
                    array[i, bottom] = counter++;
                }
                bottom--;
                for (var i = bottom; i >= top; i--)
                {
                    array[left, i] = counter++;
                }
                left++;
            }
            for (var j = 0; j < sizeArray; j++)
            {
                for (var i = 0; i < sizeArray; i++)
                {
                    Console.Write($"{array[i, j],4} ");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
        static double Function(double x)
        {
            return 5 * Math.Pow(x, 3) - 4 * x + 1;
        }
    }
}
