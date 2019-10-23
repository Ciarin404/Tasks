using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte N;
            Console.Write("Введите число:");
            while (!byte.TryParse(Console.ReadLine(), out N))
            {
                Console.Write("Введите число:");
            }
            if ((N > 18) && (N % 2 == 0))
                Console.WriteLine("Поздравляем с 18-и летием!");
            else if ((N < 18) && (N > 13) && (N % 2 != 0))
                Console.WriteLine("Поздравляем с переходом в старшую школу!");
            else Console.WriteLine("Ничего.");
            Console.ReadKey();
        }
    }
}
