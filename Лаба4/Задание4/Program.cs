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
            int count = 0;
            Console.WriteLine("Введите ряд неотрицательных чисел (конец — отрицательное):");
            double prev = Convert.ToDouble(Console.ReadLine());
            if (prev < 0)
            {
                Console.WriteLine("Чисел, больших обоих соседей: 0");
                Console.ReadLine();
                return;
            }
            double cur = Convert.ToDouble(Console.ReadLine());
            if (cur < 0)
            {
                Console.WriteLine("Чисел, больших обоих соседей: 0");
                Console.ReadLine();
                return;
            }
            while (true)
            {
                double next = Convert.ToDouble(Console.ReadLine());
                if (next < 0) break;

                if (cur > prev && cur > next)
                    count++;
                prev = cur;
                cur = next;
            }
            Console.WriteLine($"Чисел, больших обоих соседей: {count}");
            Console.ReadLine();
        }
    }
}
