using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальное количество монет: ");
            long MaxN = long.Parse(Console.ReadLine());
            long count = 0;
            long m = 1; 
            while (m <= MaxN)
            {
                count += MaxN / m;
                m = m * 2 + 1;
            }
            Console.Write("Количество комбинаций: ");
            Console.WriteLine(count);
        }
    }
}
