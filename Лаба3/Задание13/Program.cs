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
            Console.Write($"Введите {n} чисел через пробел: ");
            string[] parts = Console.ReadLine().Split(' ');
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToDouble(parts[i]);
            }
            int count = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if (a[i] > a[i - 1] && a[i] > a[i + 1])
                    count++;
            }
            Console.WriteLine($"Чисел, больших обоих соседей: {count}");
            Console.ReadLine();
        }
    }
}
