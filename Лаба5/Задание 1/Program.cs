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
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите массив X через пробел: ");
            string[] parts = Console.ReadLine().Split(' ');

            int[] X = new int[n];
            for (int i = 0; i < n; i++)
                X[i] = Convert.ToInt32(parts[i]);

            Console.Write("Введите M: ");
            int M = Convert.ToInt32(Console.ReadLine());

            int countY = 0;
            for (int i = 0; i < n; i++)
                if (Math.Abs(X[i]) > M) countY++;

            int[] Y = new int[countY];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(X[i]) > M)
                {
                    Y[k] = X[i];
                    k++;
                }
            }
            Console.WriteLine($"M = {M}");
            Console.Write("Массив X: ");
            for (int i = 0; i < n; i++) Console.Write(X[i] + " ");
            Console.WriteLine();
            Console.Write("Массив Y: ");
            for (int i = 0; i < Y.Length; i++) Console.Write(Y[i] + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
