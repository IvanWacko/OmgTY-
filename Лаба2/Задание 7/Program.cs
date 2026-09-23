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
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x == 0 && y == 0) Console.WriteLine("Точка в начале координат");
            else if (x == 0) Console.WriteLine("Точка на оси Y");
            else if (y == 0) Console.WriteLine("Точка на оси X");
            else if (x > 0 && y > 0) Console.WriteLine("I квадрант");
            else if (x < 0 && y > 0) Console.WriteLine("II квадрант");
            else if (x < 0 && y < 0) Console.WriteLine("III квадрант");
            else Console.WriteLine("IV квадрант");
        }
    }
}
