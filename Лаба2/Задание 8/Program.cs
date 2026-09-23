using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цифру (0-15): ");
            int digit = Convert.ToInt32(Console.ReadLine());
            switch (digit)
            {
                case 0: Console.WriteLine("Ноль"); break;
                case 1: Console.WriteLine("Один"); break;
                case 2: Console.WriteLine("Два"); break;
                case 3: Console.WriteLine("Три"); break;
                case 4: Console.WriteLine("Четыре"); break;
                case 5: Console.WriteLine("Пять"); break;
                case 6: Console.WriteLine("Шесть"); break;
                case 7: Console.WriteLine("Семь"); break;
                case 8: Console.WriteLine("Восемь"); break;
                case 9: Console.WriteLine("Девять"); break;
                case 10: Console.WriteLine("Десять"); break;
                case 11: Console.WriteLine("Одиннацать"); break;
                case 12: Console.WriteLine("Двенадцать"); break;
                case 13: Console.WriteLine("Тринадцать"); break;
                case 14: Console.WriteLine("Четырнадцать"); break;
                case 15: Console.WriteLine("Пятнадцать"); break;
                default: Console.WriteLine("Это не цифра"); break;
            }
        }
    }
}
