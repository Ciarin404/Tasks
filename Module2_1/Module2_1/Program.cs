using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            byte m;
            Console.Write("Введите число компаний:");
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Введите % налога:");
            m = Byte.Parse(Console.ReadLine());
            int income = 230;
            float sum;
            sum = n * income * m / 100; 
            Console.WriteLine($"Суммарный налог государства:{sum}");
            Console.ReadKey();
        }
    }
}
