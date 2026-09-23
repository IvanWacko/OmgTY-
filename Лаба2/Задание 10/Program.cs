using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - площадь круга, 2 - объем шара, 3 - объем цилиндра, 4 - площадь сферы");
            Console.Write("Введите номер фигуры: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("Введите радиус: ");
                    double r1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Площадь круга: {Math.PI * r1 * r1:F2}");
                    break;
                case 2:
                    Console.Write("Введите радиус: ");
                    double r2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Объем шара: {(4.0 / 3.0) * Math.PI * Math.Pow(r2, 3):F2}");
                    break;
                case 3:
                    Console.Write("Введите радиус: ");
                    double r3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите высоту: ");
                    double h3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Объем цилиндра: {Math.PI * r3 * r3 * h3:F2}");
                    break;
                case 4:
                    Console.Write("Введите радиус: ");
                    double r4 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Площадь сферы: {4 * Math.PI * r4 * r4:F2}");
                    break;
                default:
                    Console.WriteLine("Неверный номер");
                    break;
            }
        }
    }
}
