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
            Console.Write("Введите a: "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: "); double b = Convert.ToDouble(Console.ReadLine());
            a = a + b; 
            b = a - b; 
            a = a - b;
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
