using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
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
            Console.Write("Номера строк с равномерно убывающей последовательностью: ");
            bool any = false;

            for (int i = 0; i < n; i++)
            {
                bool ok = true;
                int diff = a[i, 0] - a[i, 1];

                for (int j = 1; j < m - 1; j++)
                {
                    if (a[i, j] - a[i, j + 1] != diff)
                    {
                        ok = false;
                        break;
                    }
                }

                if (ok && diff > 0) 
                {
                    Console.Write($"{i + 1} ");
                    any = true;
                }
            }
            if (!any) Console.Write("нет");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
