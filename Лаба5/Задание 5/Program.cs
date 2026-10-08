using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Введите {N} целых чисел через пробел: ");
            string[] parts = Console.ReadLine().Split(' ');

            int[] a = new int[N];
            for (int i = 0; i < N; i++)
                a[i] = Convert.ToInt32(parts[i]);

            int max = a[0];
            for (int i = 1; i < N; i++)
                if (a[i] > max) max = a[i];

            Console.WriteLine($"Максимальный элемент: {max}");

            Console.Write("Массив в обратном порядке: ");
            for (int i = N - 1; i >= 0; i--)
                Console.Write(a[i] + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
