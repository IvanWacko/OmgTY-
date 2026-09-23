using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во грядок: ");
            long N = long.Parse(Console.ReadLine());
            Console.Write("Введите длину грядок: ");
            long L = long.Parse(Console.ReadLine());
            Console.Write("Введите ширину грядок: ");
            long W = long.Parse(Console.ReadLine());
            Console.Write("Введите расстояние до колодца: ");
            long K = long.Parse(Console.ReadLine());
            long S = 2 * N * (L + K) + W * N * (N + 1);
            Console.WriteLine($"Минимальное расстояние: {S}");
        }
    }
}
