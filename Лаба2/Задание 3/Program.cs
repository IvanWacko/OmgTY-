using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int days;
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                days = 366;
            }
            else
            {
                days = 365;
            }
            Console.WriteLine($"Дней в году: {days}");
        }
    }
}
