using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N > 0: ");
            long n = Convert.ToInt64(Console.ReadLine());
            int count = 0;
            int sum = 0;
            while (n > 0)
            {
                int d = (int)(n % 10);
                sum += d;
                count++;
                n /= 10;
            }
            Console.WriteLine($"Количество цифр: {count}");
            Console.WriteLine($"Сумма цифр: {sum}");
            Console.ReadLine();
        }
    }
}
