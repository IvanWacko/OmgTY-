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
            Console.Write($"Введите {n} чисел через пробел: ");
            string[] parts = Console.ReadLine().Split(' ');
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(parts[i]);
            }
            int changes = 0;
            for (int i = 1; i < n; i++)
            {
                if (a[i - 1] * a[i] < 0)
                    changes++;
            }
            Console.WriteLine($"Знак меняется {changes} раз");
            Console.ReadLine();
        }
    }
}
