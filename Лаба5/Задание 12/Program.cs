using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер квадратной матрицы n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[n, n];

            Console.WriteLine("Введите матрицу построчно:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Строка {i + 1}: ");
                string[] parts = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    a[i, j] = Convert.ToInt32(parts[j]);
            }
            long sum = 0;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j > i)
                    {
                        sum += a[i, j];
                        count++;
                    }
                }
            }
            if (count > 0)
            {
                double avg = (double)sum / count;
                Console.WriteLine($"Среднее арифметическое выше диагонали: {avg:f4}");
            }
            else
            {
                Console.WriteLine("Элементов выше главной диагонали нет");
            }
            Console.ReadLine();
        }
    }
}
