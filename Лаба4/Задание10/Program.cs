using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 0;
            int bestValue = 0;
            bool found = false;
            int index = 0;
            Console.WriteLine("Введите последовательность (конец — 0):");
            while (true)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 0) break;
                index++;
                if (x < 0)
                {
                    if (!found || x > bestValue)
                    {
                        bestValue = x;
                        pos = index;
                        found = true;
                    }
                }
            }
            if (found)
                Console.WriteLine($"Номер: {pos}, величина: {bestValue}");
            else
                Console.WriteLine("Отрицательных чисел не было");
            Console.ReadLine();
        }
    }
}
