using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-круг, 2-шар, 3-цилиндр, 4-сфера, 5-прямоугольник, 6-трапеция");
            Console.Write("Введите номер фигуры: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("Радиус: "); double r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Площадь круга: {Math.PI * r * r:F2}");
                    break;
                case 2:
                    Console.Write("Радиус: "); double r2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Объем шара: {(4.0 / 3.0) * Math.PI * Math.Pow(r2, 3):F2}");
                    break;
                case 3:
                    Console.Write("Радиус: "); double r3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Высота: "); double h3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Объем цилиндра: {Math.PI * r3 * r3 * h3:F2}");
                    break;
                case 4:
                    Console.Write("Радиус: "); double r4 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Площадь сферы: {4 * Math.PI * r4 * r4:F2}");
                    break;
                case 5:
                    Console.Write("Сторона a: "); double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Сторона b: "); double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Площадь прямоугольника: {a * b:F2}");
                    break;
                case 6:
                    Console.Write("Основание a: "); double a6 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Основание b: "); double b6 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Высота h: "); double h6 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Площадь трапеции: {((a6 + b6) / 2) * h6:F2}");
                    break;
                default: Console.WriteLine("Неверный номер"); break;
            }
        }
    }
}
