using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int changes = 0;
            Console.WriteLine("Введите последовательность (конец — 0):");
            int prev = Convert.ToInt32(Console.ReadLine());
            if (prev == 0)
            {
                Console.WriteLine("Знак меняется 0 раз");
                Console.ReadLine();
                return;
            }
            while (true)
            {
                int cur = Convert.ToInt32(Console.ReadLine());
                if (cur == 0) break;

                if (prev * cur < 0) changes++;
                prev = cur;
            }
            Console.WriteLine($"Знак меняется {changes} раз");
            Console.ReadLine();
        }
    }
}
