using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0.0;
            for (int i = 1; i <= 10; i++)
            {
                x += 1.0 / i;
            }
            Console.WriteLine($"X = {x:f6}");
            Console.ReadLine();
        }
    }
}
