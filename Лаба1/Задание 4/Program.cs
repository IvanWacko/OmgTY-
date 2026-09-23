using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а:"); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b:"); double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c:"); double c = Convert.ToDouble(Console.ReadLine());
            double medianaA = 0.5 * Math.Sqrt(2 * b * b + 2 * c * c - a * a);
            double medianaB = 0.5 * Math.Sqrt(2 * a * a + 2 * c * c - b * b);
            double medianaC = 0.5 * Math.Sqrt(2 * a * a + 2 * b * b - c * c);
            Console.WriteLine($"Медианы: {medianaA}, {medianaB}, {medianaC}");
        }
    }
}
