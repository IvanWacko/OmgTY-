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
            Console.Write("Введите 20 цен через пробел: ");
            string[] parts = Console.ReadLine().Split(' ');
            double sum = 0;
            for (int i = 0; i < 20; i++)
            {
                sum += Convert.ToDouble(parts[i]);
            }
            double average = sum / 20;
            Console.WriteLine($"Средняя стоимость товара: {average:f2}");
            Console.ReadLine();
        }
    }
}