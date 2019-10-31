using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 8;
            int secondNumber = 13;
            int thirdNumber = 6;
            double firstDouble = 5.4;
            double secondDouble = 3.1;
            double thirdDouble = 2.9;
            string firstString = "First string ";
            string secondString = "second string";
            double[] firstArray = new double[7];
            double[] secondArray = new double[5];
            FillArray(firstArray);
            FillArray(secondArray);
            Console.WriteLine($"{firstNumber} + {secondNumber} = {GetSumm(firstNumber, secondNumber)}");
            Console.WriteLine($"{firstNumber} + {secondNumber} + {thirdNumber} = {GetSumm(firstNumber, secondNumber, thirdNumber)}");
            Console.WriteLine($"{firstDouble} + {secondDouble} + {thirdDouble} = {GetSumm(firstDouble, secondDouble, thirdDouble)}");
            Console.WriteLine($"{firstString} + {secondString} = {GetSumm(firstString, secondString)}");
            Console.WriteLine($"({DisplayArray(firstArray)}) + ({DisplayArray(secondArray)}) = ({DisplayArray(GetSumm(firstArray, secondArray))})");
            Console.ReadKey();
        }

        static int GetSumm(int first, int second)
        {
            return first + second;
        }

        static int GetSumm(int first, int second, int third)
        {
            return first + second + third;
        }

        static double GetSumm(double first, double second, double third)
        {
            return first + second + third;
        }

        static string GetSumm(string first, string second)
        {
            return first + second;
        }

        static string DisplayArray(double[] array)
        {
            string arrayString = default;

            foreach (var number in array)
            {
                arrayString += ($"{number} ");
            }
            return arrayString;
        }

        static void FillArray(double[] array)
        {
            var rand = new Random((int)Stopwatch.GetTimestamp());

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
            }
        }

        static double[] GetSumm(double[] first, double[] second)
        {
            if (first.Length > second.Length)
            {
                double[] summArray = new double[first.Length];
                Array.Copy(first, summArray, first.Length);

                for (var i = 0; i < second.Length; i++)
                {
                    summArray[i] += second[i];
                }
                return summArray;
            }
            else
            {
                var summArray = new double[second.Length];
                Array.Copy(first, summArray, second.Length);

                for (var i = 0; i < first.Length; i++)
                {
                    summArray[i] += first[i];
                }
                return summArray;
            }
        }
    }
}
