using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1-е число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2-е число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 3-е число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int min = Math.Min(a, Math.Min(b, c));
            Console.WriteLine($"Минимальное число: {min}");
        }
    }
}
