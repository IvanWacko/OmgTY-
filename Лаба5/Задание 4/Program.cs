using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество товаров: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите цены через пробел: ");
            string[] parts = Console.ReadLine().Split(' ');

            double[] prices = new double[n];
            for (int i = 0; i < n; i++)
                prices[i] = Convert.ToDouble(parts[i]);

            Console.Write("Введите пороговое значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (prices[i] < x)
                    prices[i] = prices[i] * 0.97;   // -3%
                else
                    prices[i] = prices[i] * 0.95;   // -5%
            }

            double min = prices[0], max = prices[0];
            for (int i = 1; i < n; i++)
            {
                if (prices[i] < min) min = prices[i];
                if (prices[i] > max) max = prices[i];
            }

            Console.Write("Новые цены: ");
            for (int i = 0; i < n; i++) Console.Write($"{prices[i]:f2} ");
            Console.WriteLine();
            Console.WriteLine($"Минимальная цена: {min:f2}");
            Console.WriteLine($"Максимальная цена: {max:f2}");
            Console.ReadLine();
        }
    }
}
