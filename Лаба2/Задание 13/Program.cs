using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double expr1 = 2 * Math.Pow(10 + Math.Sqrt(10) + 2, 1.0 / 3.0);
            double expr2 = (Math.PI / 12) * Math.Asin(Math.Sqrt(3) / 2);
            double func;
            if (expr1 > expr2)
            {
                func = Math.Acos((expr1 - expr2) / (1 + expr1 * Math.Sin(expr2)));
            }
            else
            {
                func = Math.Sin(expr2) / (expr1 * Math.Sqrt(expr1) + Math.Exp(Math.Pow(expr1, 2) - 1));
            }
            Console.WriteLine($"expr1 = {expr1}");
            Console.WriteLine($"expr2 = {expr2}");
            Console.WriteLine($"func = {func}");
        }
    }
}
