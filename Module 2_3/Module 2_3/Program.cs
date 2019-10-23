using System;
namespace Module_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float temp;
            bool i = true;
            while (i)
            {
                Console.WriteLine("Введите переменные a и b:");
                if (!((float.TryParse(Console.ReadLine().Replace('.', ','), out float a))
                    & (float.TryParse(Console.ReadLine().Replace('.', ','), out float b))))
                {
                    i = true;
                    Console.Clear();
                    Console.WriteLine("Вы ввели не числа. Попробуйте ещё раз.");
                }
                else
                {
                    i = false;
                    temp = b;
                    b = a;
                    a = temp;
                    Console.WriteLine($"a = {a}\nb = {b}");
                }

            }
           
            Console.ReadKey();
        }
    }
}