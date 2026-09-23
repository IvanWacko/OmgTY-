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
            Console.Write("Введите трехзначное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d3 = n % 10;
            int d2 = (n / 10) % 10;
            int d1 = n / 100;
            int sum = d1 + d2 + d3;
            Console.WriteLine($"Сумма цифр: {sum}");
        }
    }
}
