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
            double y = 0.0;
            for (int i = 0; i <= 10; i++)
            {
                double term = Math.Pow(3, i);
                if (i % 2 == 0)
                    y += term;
                else
                    y -= term;
            }
            Console.WriteLine($"Y = {y}");
            Console.ReadLine();
        }
    }
}
