using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int d = 1; d <= n / 2; d++)
            {
                if (n % d == 0)
                    sum += d;
            }
            if (sum == n)
                Console.WriteLine($"{n} — совершенное число");
            else
            Console.WriteLine($"{n} — не совершенное число");
            Console.ReadLine();
        }
    }
}
