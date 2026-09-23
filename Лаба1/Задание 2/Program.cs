using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а:"); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b:"); double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите h:"); double h = Convert.ToDouble(Console.ReadLine());
            double sTrap = ((a + b) / 2) * h;
            double vCone = (h / 3.0) * (a + Math.Sqrt(a * b) + b);
            Console.WriteLine($"Площадь трапеции: {sTrap}");
            Console.WriteLine($"Объём конуса: {vCone}");

        }
    }
}
