using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Введите стоимость товара №{i + 1}: ");
                double price = Convert.ToDouble(Console.ReadLine());
                sum += price;
            }
            double average = sum / 20;
            Console.WriteLine($"Средняя стоимость товара: {average:f2}");
            Console.ReadLine();
        }
    }
}