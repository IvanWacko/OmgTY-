using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
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

            int countNeg = 0;
            int maxRun = 0;
            int curRun = 0;

            for (int i = 0; i < 15; i++)
            {
                if (a[i] < 0)
                {
                    countNeg++;
                    curRun++;
                    if (curRun > maxRun) maxRun = curRun;
                }
                else
                {
                    curRun = 0;
                }
            }
            Console.WriteLine($"Отрицательных чисел: {countNeg}");
            Console.WriteLine($"Максимальная серия подряд: {maxRun}");
            Console.ReadLine();
        }
    }
}
