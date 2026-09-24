using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a и b через пробел: ");
            string[] parts = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(parts[0]);
            int b = Convert.ToInt32(parts[1]);
            int sum = 0;
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
                count++;
            }
            double average = (double)sum / count;
            Console.WriteLine($"Среднее арифметическое от {a} до {b} = {average:f4}");

            Console.ReadLine();
        }
    }
}
