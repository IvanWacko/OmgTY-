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
            Console.Write("x1: "); double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1: "); double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2: "); double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: "); double y2 = Convert.ToDouble(Console.ReadLine());
            double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние: {dist}");
        }
    }
}
