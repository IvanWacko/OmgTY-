using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество фирм: ");
            int n = int.Parse(Console.ReadLine());

            int bestFirm = 0;
            double bestPrice = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Фирма " + i);

                Console.Write("Введите размеры первой упаковки (X Y Z): ");
                string[] a = Console.ReadLine().Split();

                Console.Write("Введите размеры второй упаковки (X Y Z): ");
                string[] b = Console.ReadLine().Split();

                Console.Write("Введите стоимость первой и второй упаковки: ");
                string[] c = Console.ReadLine().Split();

                double x1 = double.Parse(a[0]);
                double y1 = double.Parse(a[1]);
                double z1 = double.Parse(a[2]);

                double x2 = double.Parse(b[0]);
                double y2 = double.Parse(b[1]);
                double z2 = double.Parse(b[2]);

                double c1 = double.Parse(c[0]);
                double c2 = double.Parse(c[1]);

                double v1 = x1 * y1 * z1 / 1000;
                double v2 = x2 * y2 * z2 / 1000;

                double s1 = 2 * (x1 * y1 + x1 * z1 + y1 * z1);
                double s2 = 2 * (x2 * y2 + x2 * z2 + y2 * z2);

                double price = (c1 * s2 - c2 * s1) / (v1 * s2 - v2 * s1);

                if (price < bestPrice)
                {
                    bestPrice = price;
                    bestFirm = i;
                }
            }

            Console.WriteLine(bestFirm + " " + bestPrice.ToString("F2"));
        }
    }
}
