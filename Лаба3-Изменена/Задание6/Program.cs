using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int positives = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите число №{i + 1}: ");
                int x = Convert.ToInt32(Console.ReadLine());
                sum += x;
                if (x > 0) positives++;
            }
            Console.WriteLine($"Сумма всех чисел: {sum}");
            Console.WriteLine($"Количество положительных: {positives}");
            Console.ReadLine();
        }
    }
}