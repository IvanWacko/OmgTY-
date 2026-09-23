using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x: "); double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: "); double y = Convert.ToDouble(Console.ReadLine());
            double f;
            if (Math.Abs(x) >= Math.Abs(y))
            {
                f = Math.Log(Math.Abs(x + y)) / (Math.Log(Math.Abs(x)) + Math.Log(Math.Abs(y)))
                    - Math.Sin(Math.Pow(Math.Pow(x, 8) + Math.Pow(y, 4), 1.0 / 3.0));
            }
            else
            {
                f = Math.Asin(Math.Abs(x) / Math.Sqrt(x * x + Math.Pow(y, 4)))
                    + Math.Exp(Math.Cos(Math.Sqrt(Math.Abs(x + y))));
            }
            double u;
            if (Math.Pow(x, 8) + Math.Pow(y, 8) >= 12)
            {
                u = Math.Sin(x - y / (Math.Pow(x, 8) + Math.Pow(y, 8)));
            }
            else
            {
                u = Math.Cos(x - y / (Math.Pow(x, 8) + Math.Pow(y, 8)));
            }
            Console.WriteLine($"f = {f:F4}");
            Console.WriteLine($"u = {u:F4}");
        }
    }
}
