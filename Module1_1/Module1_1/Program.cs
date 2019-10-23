using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12, y = 7, temp;
            Console.WriteLine($"x = {x}, y = {y}");
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"После переменны значений: x = {x}, y = {y}");
            Console.ReadKey();
        }
    }
}
