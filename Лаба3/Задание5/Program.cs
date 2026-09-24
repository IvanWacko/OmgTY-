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
            double distance = 10.0;
            double total = 10.0;
            Console.WriteLine($"День 1: {distance:f2} км");
            for (int day = 2; day <= 10; day++)
            {
                distance *= 1.10;
                total += distance;

                Console.WriteLine($"День {day}: {distance:f2} км");
                if (day == 7)
                {
                    Console.WriteLine($"  Суммарно за 7 дней: {total:f2} км");
                }
            }
            Console.ReadLine();
        }
    }
}