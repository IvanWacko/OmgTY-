using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int changes = 0;
            Console.Write("Введите число №1: ");
            int prev = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                Console.Write($"Введите число №{i}: ");
                int cur = Convert.ToInt32(Console.ReadLine());
                if (prev * cur < 0)
                    changes++;
                prev = cur;
            }
            Console.WriteLine($"Знак меняется {changes} раз");
            Console.ReadLine();
        }
    }
}
