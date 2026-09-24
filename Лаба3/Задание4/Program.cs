using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long cells = 1;
            for (int hour = 3; hour <= 24; hour += 3)
            {
                cells *= 2;
                Console.WriteLine($"Через {hour} ч: {cells} клеток");
            }
            Console.ReadLine();
        }
    }
}