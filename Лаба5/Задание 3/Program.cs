using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 15 целых чисел через пробел: ");
            string[] parts = Console.ReadLine().Split(' ');

            int[] a = new int[15];
            for (int i = 0; i < 15; i++)
                a[i] = Convert.ToInt32(parts[i]);

            int max = a[0];
            for (int i = 1; i < 15; i++)
                if (a[i] > max) max = a[i];

            int countMax = 0;
            for (int i = 0; i < 15; i++)
                if (a[i] == max) countMax++;

            Console.WriteLine($"Наибольшее: {max}");
            Console.WriteLine($"Встречается {countMax} раз");
            Console.ReadLine();
        }
    }
}
