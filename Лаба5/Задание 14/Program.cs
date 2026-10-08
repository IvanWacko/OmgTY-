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
            int target = 0;
            for (int j = 0; j < n; j++) target += a[0, j];

            bool magic = true;

            for (int i = 0; i < n && magic; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < n; j++) rowSum += a[i, j];
                if (rowSum != target) magic = false;
            }
            for (int j = 0; j < n && magic; j++)
            {
                int colSum = 0;
                for (int i = 0; i < n; i++) colSum += a[i, j];
                if (colSum != target) magic = false;
            }
            int diag1 = 0;
            for (int i = 0; i < n; i++) diag1 += a[i, i];
            if (diag1 != target) magic = false;

            int diag2 = 0;
            for (int i = 0; i < n; i++) diag2 += a[i, n - 1 - i];
            if (diag2 != target) magic = false;

            if (magic)
                Console.WriteLine("Магический квадрат");
            else
                Console.WriteLine("Не магический квадрат");
            Console.ReadLine();
        }
    }
}
