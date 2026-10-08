using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10
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
            for (int i = 0; i < n; i++)
            {
                for (int k = i + 1; k < n; k++)
                {
                    bool same = true;
                    for (int j = 0; j < m; j++)
                    {
                        if (a[i, j] != a[k, j])
                        {
                            same = false;
                            break;
                        }
                    }
                    if (same)
                        Console.WriteLine($"Строки {i + 1} и {k + 1} одинаковы");
                }
            }
            Console.ReadLine();
        }
    }
}
