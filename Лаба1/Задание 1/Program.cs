using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
  class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во секунд");
                string input = Console.ReadLine();
            int k = 10000;
            int h = k / 3600;
            int remainingSeconds = k % 3600;
            int m = remainingSeconds / 60;
            int s = k % 60;
            Console.WriteLine($"{h} Часа {m} Минут {s} Секунд");
        }
    }
}
