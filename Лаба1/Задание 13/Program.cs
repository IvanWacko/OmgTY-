using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Катет 1: "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Катет 2: "); double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"Гипотенуза: {c:F5}");
        }
    }
}
