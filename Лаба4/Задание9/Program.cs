using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            long n = Convert.ToInt64(Console.ReadLine());
            long product = 1;
            while (n > 0)
            {
                int d = (int)(n % 10);
                product *= d;
                n /= 10;
            }
            Console.WriteLine($"Произведение цифр: {product}");
            Console.ReadLine();
        }
    }
}
