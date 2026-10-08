using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите X, Y, L, C1, C2, C3, C4, C5, C6 через пробел: ");
            string[] parts = Console.ReadLine().Split(' ');

            int X = Convert.ToInt32(parts[0]);
            int Y = Convert.ToInt32(parts[1]);
            int L = Convert.ToInt32(parts[2]);
            int C1 = Convert.ToInt32(parts[3]);
            int C2 = Convert.ToInt32(parts[4]);
            int C3 = Convert.ToInt32(parts[5]);
            int C4 = Convert.ToInt32(parts[6]);
            int C5 = Convert.ToInt32(parts[7]);
            int C6 = Convert.ToInt32(parts[8]);

            int P = 2 * (X + Y);

            int best = int.MaxValue;

            for (int r = 0; r <= L; r++)
            {
                for (int d = 0; d <= L - r; d++)
                {
                    int w = L - r - d;

                    int n = P - r - d;
                    if (n < 0) n = 0;

                    int cost = r * C1
                             + d * (C2 + C3)
                             + w * (C2 + C6)
                             + n * (C4 + C5);

                    if (cost < best) best = cost;
                }
            }
            Console.WriteLine($"Минимальная сумма: {best}");
            Console.ReadLine();
        }
    }
    }
