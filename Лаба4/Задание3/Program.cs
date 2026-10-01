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
                    int temp = -x;
                    int oddCount = 0;
                    while (temp > 0)
                    {
                        int d = temp % 10;
                        if (d % 2 == 1) oddCount++;
                        temp /= 10;
                    }

                    if (oddCount % 2 == 0)
                    {
                        if (!found || x > bestValue)
                        {
                            bestValue = x;
                            pos = index;
                            found = true;
                        }
                    }
                }
            }

            if (found)
                Console.WriteLine($"Номер: {pos}, величина: {bestValue}");
            else
                Console.WriteLine("Подходящих чисел не найдено");
            Console.ReadLine();
        }
    }
}
