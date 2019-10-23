using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA, sideB, sideC, sideD, r, halfP;
            bool i = true;
            byte selection;
            while (i)
            {
                Console.Write("Выберите фигуру для подсчета 1)треугольник 2)четырехугольник 3)круг:");
                string selectionFigure = Console.ReadLine();
                switch (selectionFigure)
                {
                    case "1":
                        double triangleP, triangleS;
                        i = false;
                        Console.Write("Выберите что будем считать 1)Периметр 2)Площадь:");
                        selection = byte.Parse(Console.ReadLine());
                        if (selection == 1)
                        {
                            Console.WriteLine("Введите стороны треугольника:");
                            Console.Write("a = ");
                            sideA = double.Parse(Console.ReadLine());
                            Console.Write("b = ");
                            sideB = double.Parse(Console.ReadLine());
                            Console.Write("c = ");
                            sideC = double.Parse(Console.ReadLine());
                            triangleP = sideA + sideB + sideC;
                            Console.WriteLine($"Периметр треугольника = {triangleP}");
                            Console.WriteLine($"Радиус окружности с периметром {triangleP} = {triangleP / 2 * Math.PI}");
                            Console.WriteLine($"Сторона четырехугольника с периметром {triangleP} = {triangleP / 4}");
                        }
                        else if (selection == 2)
                        {
                            Console.WriteLine("Введите стороны треугольника:");
                            Console.Write("a = ");
                            sideA = double.Parse(Console.ReadLine());
                            Console.Write("b = ");
                            sideB = double.Parse(Console.ReadLine());
                            Console.Write("c = ");
                            sideC = double.Parse(Console.ReadLine());
                            triangleP = sideA + sideB + sideC;
                            halfP = triangleP / 2;
                            triangleS = Math.Sqrt(halfP * (halfP - sideA) * (halfP - sideB) * (halfP - sideC));
                            Console.WriteLine($"Площадь треугольника = {triangleS}");
                            Console.WriteLine($"Радиус окружности с площадью {triangleS} = {Math.Sqrt(triangleS / Math.PI)}");
                            Console.WriteLine($"Сторона четырехугольника с площадью {triangleS} = {Math.Sqrt(triangleS)}");
                        }
                        break;
                    case "2":
                        double quadrangleP, quadrangleS;
                        i = false;
                        Console.Write("Выберите что будем считать 1)Периметр 2)Площадь:");
                        selection = byte.Parse(Console.ReadLine());
                        if (selection == 1)
                        {
                            Console.WriteLine("Введите стороны четырехугольника:");
                            Console.Write("a = ");
                            sideA = double.Parse(Console.ReadLine());
                            Console.Write("b = ");
                            sideB = double.Parse(Console.ReadLine());
                            Console.Write("c = ");
                            sideC = double.Parse(Console.ReadLine());
                            Console.Write("d = ");
                            sideD = double.Parse(Console.ReadLine());
                            quadrangleP = sideA + sideB + sideC + sideD;
                            Console.WriteLine($"Периметр четырехугольника = {quadrangleP}");
                            Console.WriteLine($"Радиус окружности с периметром {quadrangleP} = {quadrangleP / 2 * Math.PI}");
                            Console.WriteLine($"Сторона треугольника с периметром {quadrangleP} = {quadrangleP / 3}");
                        }
                        else if (selection == 2)
                        {
                            Console.WriteLine("Введите стороны треугольника:");
                            Console.Write("a = ");
                            sideA = double.Parse(Console.ReadLine());
                            Console.Write("b = ");
                            sideB = double.Parse(Console.ReadLine());
                            Console.Write("c = ");
                            sideC = double.Parse(Console.ReadLine());
                            Console.Write("d = ");
                            sideD = double.Parse(Console.ReadLine());
                            quadrangleP = sideA + sideB + sideC + sideD;
                            halfP = quadrangleP / 2;
                            quadrangleS = Math.Sqrt(halfP * (halfP - sideA) * (halfP - sideB) * (halfP - sideC) * (halfP = sideD));
                            Console.WriteLine($"Площадь четырхугольника = {quadrangleS}");
                            Console.WriteLine($"Радиус окружности с площадью {quadrangleS} = {Math.Sqrt(quadrangleS / Math.PI)}");
                            Console.WriteLine($"Сторона треугольника с площадью {quadrangleS} = {Math.Sqrt(4 * quadrangleS / Math.Sqrt(3))}");
                        }
                        break;
                    case "3":
                        double circleP, circleS;
                        i = false;
                        Console.Write("Выберите что будем считать 1)Периметр 2)Площадь:");
                        selection = byte.Parse(Console.ReadLine());
                        if (selection == 1)
                        {
                            Console.WriteLine("Введите радиус круга:");
                            Console.Write("r = ");
                            r = double.Parse(Console.ReadLine());
                            circleP = 2 * r * Math.PI;
                            Console.WriteLine($"Периметр круга = {circleP}");
                            Console.WriteLine($"Сторона четырехугольника с периметром {circleP} = {circleP / 4}");
                            Console.WriteLine($"Сторона треугольника с периметром {circleP} = {circleP / 3}");
                        }
                        else if (selection == 2)
                        {
                            Console.WriteLine("Введите радиус круга:");
                            Console.Write("r = ");
                            r = double.Parse(Console.ReadLine());
                            circleS = r * r * Math.PI;
                            Console.WriteLine($"Площадь круга = {circleS}");
                            Console.WriteLine($"Сторона четырехугольника с площадью {circleS} = {Math.Sqrt(circleS)}");
                            Console.WriteLine($"Сторона треугольника с площадью {circleS} = {Math.Sqrt(4 * circleS / Math.Sqrt(3))}");
                        }
                        break;
                    default:
                        Console.WriteLine("Выбрана не верная фигура.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
