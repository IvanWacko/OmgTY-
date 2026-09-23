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
            Console.Write("Введите число k (1-30): ");
            int k = Convert.ToInt32(Console.ReadLine());
            int dayOfWeek = k % 7;
            switch (dayOfWeek)
            {
                case 1: Console.WriteLine("Понедельник"); break;
                case 2: Console.WriteLine("Вторник"); break;
                case 3: Console.WriteLine("Среда"); break;
                case 4: Console.WriteLine("Четверг"); break;
                case 5: Console.WriteLine("Пятница"); break;
                case 6: Console.WriteLine("Суббота"); break;
                case 0: Console.WriteLine("Воскресенье"); break;
            }
        }
    }
}
