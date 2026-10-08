using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15
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
            int maxI = 0, maxJ = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (a[i, j] > a[maxI, maxJ]) { maxI = i; maxJ = j; }

            if (maxI != 0)
            {
                for (int j = 0; j < m; j++)
                {
                    int t = a[0, j];
                    a[0, j] = a[maxI, j];
                    a[maxI, j] = t;
                }
            }

            if (maxJ != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    int t = a[i, 0];
                    a[i, 0] = a[i, maxJ];
                    a[i, maxJ] = t;
                }
            }

            Console.WriteLine("Матрица после перестановки:");
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
