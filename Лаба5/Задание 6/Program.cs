using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите массив D через пробел: ");
            string[] parts = Console.ReadLine().Split(' ');

            int[] D = new int[n];
            for (int i = 0; i < n; i++)
                D[i] = Convert.ToInt32(parts[i]);

            int sum = 0;
            for (int i = 1; i < n; i += 2)
                sum += D[i];

            Console.Write("Массив D: ");
            for (int i = 0; i < n; i++) Console.Write(D[i] + " ");
            Console.WriteLine();

            Console.WriteLine($"Сумма элементов с нечётными индексами: {sum}");
            Console.ReadLine();
        }
    }
}
