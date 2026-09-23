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
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int remainder = num % 5;
            switch (remainder)
            {
                case 0: Console.WriteLine("Ноль"); break;
                case 1: Console.WriteLine("Один"); break;
                case 2: Console.WriteLine("Два"); break;
                case 3: Console.WriteLine("Три"); break;
                case 4: Console.WriteLine("Четыре"); break;
            }
        }
    }
}
