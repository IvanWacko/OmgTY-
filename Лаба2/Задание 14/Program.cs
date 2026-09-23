using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p = Math.Exp(Math.Sin(2.0 / 3.0)) + Math.Log(Math.Atan(3.0 / 4.0));
            double q = 7.5 * Math.Pow(2.8, 8) - Math.Log10(Math.Sqrt(1.6));
            double u;
            if (Math.Pow(p, 2) > q)
            {
                u = Math.Sqrt(Math.Pow(p, 2) - q);
            }
            else
            {
                u = 2 * Math.Asin(Math.Pow(p, 2) / q);
            }
            double f;
            if (Math.Pow(p, 2) > q)
            {
                f = Math.Sin(Math.Pow(p, 2));
            }
            else
            {
                f = Math.Sin(q);
            }
            Console.WriteLine($"p = {p}");
            Console.WriteLine($"q = {q}");
            Console.WriteLine($"u = {u}");
            Console.WriteLine($"f = {f}");
        }
    }
}
