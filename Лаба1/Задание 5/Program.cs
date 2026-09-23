using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            Console.Write("Введите R: "); double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите h: "); double h = Convert.ToDouble(Console.ReadLine());
            double l = Math.Sqrt(r * r + h * h);
            double sSurf = Math.PI * r * (r + l);
            double v = (1.0 / 3.0) * Math.PI * r * r * h;
            Console.WriteLine($"Площадь поверхности: {sSurf:F2}");
            Console.WriteLine($"Объём: {v:F2}");
        }
    }
}
