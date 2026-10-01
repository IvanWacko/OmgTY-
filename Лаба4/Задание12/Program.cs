using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long f0 = 1;
            long f1 = 1;
            long sum = f0 + f1;
            while (true)
            {
                long f2 = f0 + f1;
                if (f2 > 1000) break;
                sum += f2;
                f0 = f1;
                f1 = f2;
            }
            Console.WriteLine($"Сумма чисел Фибоначчи ≤ 1000: {sum}");
            Console.ReadLine();
        }
    }
}
