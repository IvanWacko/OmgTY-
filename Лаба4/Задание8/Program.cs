using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x (в радианах): ");
            double x = Convert.ToDouble(Console.ReadLine());
            double eps = 0.0001;
            double term = 1.0;
            double y = 1.0;
            int n = 1;
            while (true)
            {
                term = -term * x * x / ((2.0 * n - 1) * (2.0 * n));
                if (Math.Abs(term) < eps) break;
                y += term;
                n++;
            }
            Console.WriteLine($"y (ряд)       = {y:f6}");
            Console.WriteLine($"y (Math.Cos)  = {Math.Cos(x):f6}");
            Console.ReadLine();
        }
    }
}
