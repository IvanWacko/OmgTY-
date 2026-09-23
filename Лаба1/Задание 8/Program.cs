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
            Console.Write("Введите число 1: "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число 2: "); double b = Convert.ToDouble(Console.ReadLine());
            double max = (a + b + Math.Abs(a - b)) / 2;
            Console.WriteLine($"Максимум: {max}");
        }
    }
}
