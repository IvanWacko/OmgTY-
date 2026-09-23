using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму покупки: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            double finalSum = sum;
            if (sum > 1000)
            {
                finalSum = sum * 0.95;
            }
            else if (sum > 500)
            {
                finalSum = sum * 0.97;
            }
            Console.WriteLine($"Итоговая стоимость: {finalSum:F2}");
        }
    }
}
