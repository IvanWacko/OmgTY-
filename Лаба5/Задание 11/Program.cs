using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
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
            Console.Write("Номера столбцов, где сумма > произведения: ");
            bool any = false;

            for (int j = 0; j < m; j++)
            {
                long sum = 0;
                long product = 1;

                for (int i = 0; i < n; i++)
                {
                    sum += a[i, j];
                    product *= a[i, j];
                }
                if (sum > product)
                {
                    Console.Write($"{j + 1} ");
                    any = true;
                }
            }
            if (!any) Console.Write("нет");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
