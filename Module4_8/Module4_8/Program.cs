using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double leftBound = GetData("left bound: ");
            double rightBound = GetData("right bound: ");
            double accuracy = GetData("accuracy: ");
            double solution = FindSolution(leftBound, rightBound, accuracy);
            Console.WriteLine($"Solution x = {solution}");
            Console.ReadKey();
        }

        static double GetData(string query)
        {
            while (true)
            {
                Console.Write($"Enter {query}");

                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    return number;
                }

                Console.WriteLine("Entered string is not a number!\n______________________________");
            }
        }

        static double FindSolution(double leftBound, double rightBound, double accuracy)
        {
            double solution = (leftBound + rightBound) / 2;

            if (Function(leftBound) * Function(solution) < 0)
            {
                rightBound = solution;
            }

            if (Function(rightBound) * Function(solution) < 0)
            {
                leftBound = solution;
            }

            if (Math.Abs(rightBound - leftBound) > accuracy)
            {
                return (leftBound + rightBound) / 2;
            }

            return FindSolution(leftBound, rightBound, accuracy);
        }

        static double Function(double x)
        {
            return 4 * Math.Pow(x, 3) + 4 * x + 1;
        }
    }
}
