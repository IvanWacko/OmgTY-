using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x: "); double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: "); double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("z: "); double z = Convert.ToDouble(Console.ReadLine());
            double u = Math.Abs(Math.Cos(x + Math.Pow(y, 1.0 / 3.0))) +
                       Math.Sin(z - Math.Pow(x, 10) / (1 + y * y + z * z));
            double v = Math.Exp(-x * x) + Math.Sqrt(Math.Abs(x + y + z)) + Math.Exp(y);
            double t;
            if (u * u + v * v > 5)
            {
                t = Math.Log(v + u * u + Math.Sqrt(5)) / Math.Log(2);
            }
            else
            {
                t = Math.Log(v + Math.Pow(u, 2.0 / 3.0) + Math.Sin(Math.Sqrt(5)));
            }
            Console.WriteLine($"u = {u:F4}");
            Console.WriteLine($"v = {v:F4}");
            Console.WriteLine($"t = {t:F4}");
        }
    }
}
