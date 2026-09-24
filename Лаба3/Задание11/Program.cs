using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            long y = 1;
            for (int i = 1; i <= n; i++)
            {
                y *= i;
            }
            Console.WriteLine($"Y = {n}! = {y}");
            Console.ReadLine();
        }
    }
}
