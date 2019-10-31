using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_5
{
    enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    enum Month
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number, x = ");
            double firstNumber = ParseDouble();
            Console.Write("Enter the second number, y = ");
            double secondNumber = ParseDouble();

            Console.WriteLine($"\n{firstNumber} + {secondNumber} = {MathOperation(firstNumber, secondNumber, Operation.Add)}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {MathOperation(firstNumber, secondNumber, Operation.Subtract)}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {MathOperation(firstNumber, secondNumber, Operation.Multiply)}");

            if (secondNumber == 0)
            {
                Console.WriteLine("Division by 0 is not possible");
            }
            else
            {
                Console.WriteLine($"{firstNumber} / {secondNumber} = {MathOperation(firstNumber, secondNumber, Operation.Divide):.000}");
            }

            Console.Write("\nEnter number of month: ");
            int month = GetMonth();

            int year = 2001;

            if (month == 2)
            {
                Console.Write("Enter year: ");
                year = GetYear();
            }

            Console.Write($"\nThere are {GetNumberOfDaysInMonth(year, month)} days in {(Month)month} ");

            Console.Read();
        }

        static int GetNumberOfDaysInMonth(int year, int monthNumber)
        {
            int days = DateTime.DaysInMonth(year, monthNumber);
            return days;
        }

        static double MathOperation(double firstNumber, double secondNumber, Operation operation)
        {
            double result = 0;
            switch (operation)
            {
                case Operation.Add:
                    result = firstNumber + secondNumber;
                    break;
                case Operation.Subtract:
                    result = firstNumber - secondNumber;
                    break;
                case Operation.Multiply:
                    result = firstNumber * secondNumber;
                    break;
                case Operation.Divide:
                    result = firstNumber / secondNumber;
                    break;
            }
            return result;
        }

        static double ParseDouble()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    return number;
                }

                Console.WriteLine($"Entered string is not a number.\n___________________");
            }
        }
        static int GetMonth()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int month) && month > 0 && month < 13)
                {
                    return month;
                }

                Console.WriteLine($"Entered string is not in range 1-12.\n___________________");
            }
        }
        static int GetYear()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int year) && year > 0 && year < 2501)
                {
                    return year;
                }

                Console.WriteLine($"Entered string is not in range 1-2500.\n___________________");
            }
        }
    }
}
