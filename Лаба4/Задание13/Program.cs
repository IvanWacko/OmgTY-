using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            long n = Convert.ToInt64(Console.ReadLine());
            long original = n;
            long reversed = 0;
            while (n > 0)
            {
                long d = n % 10;
                reversed = reversed * 10 + d;
                n /= 10;
            }
            if (reversed == original)
                Console.WriteLine($"{original} — палиндром");
            else
                Console.WriteLine($"{original} — не палиндром");
            Console.ReadLine();
        }
    }
}
