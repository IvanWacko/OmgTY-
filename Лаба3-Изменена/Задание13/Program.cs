using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            if (n >= 3)
            {
                Console.Write("Введите число №1: ");
                double prev = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите число №2: ");
                double cur = Convert.ToDouble(Console.ReadLine());
                for (int i = 3; i <= n; i++)
                {
                    Console.Write($"Введите число №{i}: ");
                    double next = Convert.ToDouble(Console.ReadLine());
                    if (cur > prev && cur > next)
                        count++;
                    prev = cur;
                    cur = next;
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"Введите число №{i}: ");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Чисел, больших обоих соседей: {count}");
            Console.ReadLine();
        }
    }
}
