using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2: "); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 3: "); int c = Convert.ToInt32(Console.ReadLine());
            double avg = (a + b + c) / 3.0;
            Console.WriteLine($"Среднее: {avg:F2}");
        }
    }
}
