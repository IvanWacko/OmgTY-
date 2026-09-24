using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цену 1 кг конфет: ");
            double price = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} кг стоят {i * price:f2}");
            }
    }
  }
}
