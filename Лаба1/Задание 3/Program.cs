using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите R: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double vBall = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
            double sCircle = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Объём шара: {vBall}");
            Console.WriteLine($"Площаь круга: {sCircle}");
            Console.WriteLine($"Соотношение (V/S): {vBall / sCircle}");
        }
    }
}
