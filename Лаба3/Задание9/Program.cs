using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0.0;
            for (int i = 1; i <= 9; i++)
            {
                if (i % 2 == 1)
                    y += i * i * x;
                else
                    y -= i * i * x;
            }
            Console.WriteLine($"Y = {y:f4}");
            Console.ReadLine();
        }
    }
}
