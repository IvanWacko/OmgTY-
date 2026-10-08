using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 4];

            Console.WriteLine("Введите 12 чисел (по 4 в строке):");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Строка {i + 1}: ");
                string[] parts = Console.ReadLine().Split(' ');
                for (int j = 0; j < 4; j++)
                    a[i, j] = Convert.ToInt32(parts[j]);
            }
            long product = 1;
            bool hasPositives = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i, j] > 0)
                    {
                        product *= a[i, j];
                        hasPositives = true;
                    }
                }
            }
            if (hasPositives)
                Console.WriteLine($"Произведение положительных: {product}");
            else
                Console.WriteLine("Положительных нет");

            for (int i = 0; i < 3; i++)
            {
                int max = a[i, 0];
                for (int j = 1; j < 4; j++)
                    if (a[i, j] > max) max = a[i, j];

                Console.WriteLine($"Максимум в строке {i + 1}: {max}");
            }
            Console.ReadLine();
        }
    }
}
