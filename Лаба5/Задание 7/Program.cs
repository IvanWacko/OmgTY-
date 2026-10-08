using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите массив через пробел: ");
            string[] parts = Console.ReadLine().Split(' ');

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(parts[i]);

            bool foundAny = false;

            for (int i = 0; i < n; i++)
            {
                bool seenBefore = false;
                for (int j = 0; j < i; j++)
                {
                    if (a[j] == a[i])
                    {
                        seenBefore = true;
                        break;
                    }
                }

                if (seenBefore) continue;
                int count = 0;
                for (int j = 0; j < n; j++)
                    if (a[j] == a[i]) count++;

                if (count > 1)
                {
                    Console.WriteLine($"{a[i]} встречается {count} раз");
                    foundAny = true;
                }
            }

            if (!foundAny)
                Console.WriteLine("Повторяющихся элементов нет");
            Console.ReadLine();
        }
    }
}
