using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
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
            int count = 0;
            if (a > 0) count++;
            if (b > 0) count++;
            if (c > 0) count++;
            Console.WriteLine($"Количество положительных: {count}");
        }
    }
}
