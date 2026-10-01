using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x (в радианах): ");
            double x = Convert.ToDouble(Console.ReadLine());
            double eps = 0.00001;
            double term = x;
            double y = x;
            int n = 1;
            while (true)
            {
                term = -term * x * x / ((2.0 * n) * (2.0 * n + 1));
                if (Math.Abs(term) < eps) break;
                y += term;
                n++;
            }
            Console.WriteLine($"y (ряд)       = {y:f6}");
            Console.WriteLine($"y (Math.Sin)  = {Math.Sin(x):f6}");
            Console.ReadLine();
        }
    }
}
