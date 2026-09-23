using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Товар 1: "); double p1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Товар 2: "); double p2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Товар 3: "); double p3 = Convert.ToDouble(Console.ReadLine());
            double total = p1 + p2 + p3;
            double discount = total * 0.13; // 13% = 0.13
            Console.WriteLine($"Сумма скидки: {discount:F1}");
        }
    }
}
