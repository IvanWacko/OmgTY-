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
            Console.Write("Введите n и m через пробел: ");
            string[] nm = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nm[0]);
            int m = Convert.ToInt32(nm[1]);

            int[,] a = new int[n, m];

            Console.WriteLine("Введите матрицу построчно:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Строка {i + 1}: ");
                string[] parts = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                    a[i, j] = Convert.ToInt32(parts[j]);
            }

            bool found = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int rowMin = a[i, 0];
                    for (int k = 1; k < m; k++)
                        if (a[i, k] < rowMin) rowMin = a[i, k];

                    int colMax = a[0, j];
                    for (int k = 1; k < n; k++)
                        if (a[k, j] > colMax) colMax = a[k, j];

                    if (a[i, j] == rowMin && a[i, j] == colMax)
                    {
                        Console.WriteLine($"Седловая точка: a[{i + 1},{j + 1}] = {a[i, j]}");
                        found = true;
                    }
                    int rowMax = a[i, 0];
                    for (int k = 1; k < m; k++)
                        if (a[i, k] > rowMax) rowMax = a[i, k];
                    int colMin = a[0, j];
                    for (int k = 1; k < n; k++)
                        if (a[k, j] < colMin) colMin = a[k, j];

                    if (a[i, j] == rowMax && a[i, j] == colMin)
                    {
                        Console.WriteLine($"Седловая точка: a[{i + 1},{j + 1}] = {a[i, j]}");
                        found = true;
                    }
                }
            }
            if (!found)
                Console.WriteLine("Седловых точек нет");
            Console.ReadLine();
        }
    }
}
