using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0.0;
            for (int denom = 1; denom <= 17; denom += 2)
            {
                y += x / denom;
            }
            Console.WriteLine($"Y = {y:f4}");
            Console.ReadLine();
        }
    }
}
