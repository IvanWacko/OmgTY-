using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество солдат: ");
            long N = long.Parse(Console.ReadLine());
            long count = 0;
            long pow2 = 1;
            long Z = 0;
            while ((N + pow2 - 1) / pow2 > 3) 
            {
                pow2 *= 2;
                Z++;
            }
            if (pow2 == 1)
            {
                if (N == 3) count = 1;
                else count = 0;
            }
            else
            {
                long bigSize = (N + pow2 - 1) / pow2;
                long r = N % pow2;
                if (r == 0) r = pow2;

                if (bigSize == 3)
                {
                    count = r;
                }
                else if (bigSize < 3)
                {
                    count = 0;
                }
            }
            Console.Write("Количество групп по 3 человека: ");
            Console.WriteLine(count);
        }
    }
}
