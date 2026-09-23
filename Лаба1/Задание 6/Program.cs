using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите R: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double v = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
            double s = 4 * Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Объём: {v:F3}");
            Console.WriteLine($"Площадь: {s:F3}");
        }
    }
}
