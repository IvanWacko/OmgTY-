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
            int sum = 0;
            int countWith2 = 0;
            Console.WriteLine("Введите последовательность целых чисел (конец — 0):");
            while (true)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 0) break;
                int digitsSum = 0;
                bool hasTwo = false;
                int temp = x;
                if (temp < 0) temp = -temp;
                if (temp == 0)
                {
                    digitsSum = 0;
                }
                else
                {
                    while (temp > 0)
                    {
                        int d = temp % 10;
                        digitsSum += d;
                        if (d == 2) hasTwo = true;
                        temp /= 10;
                    }
                }
                bool isPrime = true;
                if (digitsSum < 2) isPrime = false;
                else
                {
                    for (int d = 2; d * d <= digitsSum; d++)
                    {
                        if (digitsSum % d == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime) sum += x;
                if (x > 0 && hasTwo) countWith2++;
            }
            Console.WriteLine($"а) Сумма чисел с простой суммой цифр: {sum}");
            Console.WriteLine($"б) Положительных чисел с цифрой 2: {countWith2}");
            Console.ReadLine();
        }
    }
}
