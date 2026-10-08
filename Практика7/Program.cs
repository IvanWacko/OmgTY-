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
            Console.Write("Введите количество действий N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            long a = 1;
            long b = 0;

            Console.WriteLine("Введите действия (формат: S V):");
            for (int i = 0; i < N; i++)
            {
                string[] parts = Console.ReadLine().Split(' ');

                string S = parts[0];
                string V = parts[1];

                if (S == "+")
                {
                    if (V == "x") a = a + 1;
                    else b = b + Convert.ToInt64(V);
                }
                else if (S == "-")
                {
                    if (V == "x") a = a - 1;
                    else b = b - Convert.ToInt64(V);
                }
                else
                {
                    long v = Convert.ToInt64(V);
                    a = a * v;
                    b = b * v;
                }
            }
            Console.Write("Введите результат R: ");
            long R = Convert.ToInt64(Console.ReadLine());

            long X = (R - b) / a;

            Console.WriteLine($"Задуманное число: {X}");
            Console.ReadLine();
        }
    }
}
