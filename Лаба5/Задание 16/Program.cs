using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App16
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
            int[] key = new int[m];
            for (int j = 0; j < m; j++)
            {
                int sumEven = 0;
                bool hasEven = false;
                int maxCol = a[0, j];

                for (int i = 0; i < n; i++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        sumEven += a[i, j];
                        hasEven = true;
                    }
                    if (a[i, j] > maxCol) maxCol = a[i, j];
                }
                if (hasEven) key[j] = sumEven;
                else key[j] = maxCol;
            }
            for (int j1 = 0; j1 < m - 1; j1++)
            {
                for (int j2 = 0; j2 < m - 1 - j1; j2++)
                {
                    if (key[j2] < key[j2 + 1])
                    {
                        int tk = key[j2];
                        key[j2] = key[j2 + 1];
                        key[j2 + 1] = tk;

                        for (int i = 0; i < n; i++)
                        {
                            int t = a[i, j2];
                            a[i, j2] = a[i, j2 + 1];
                            a[i, j2 + 1] = t;
                        }
                    }
                }
            }
            Console.WriteLine("Матрица после сортировки столбцов:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
