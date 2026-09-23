using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1-e число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2-e число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 3-e число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Числа в интервале [1, 3]: ");
            if (a >= 1 && a <= 3) Console.Write(a + " ");
            if (b >= 1 && b <= 3) Console.Write(b + " ");
            if (c >= 1 && c <= 3) Console.Write(c + " ");
        }
    }
}
