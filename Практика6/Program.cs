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
            List<string> spells = new List<string>();
            Console.WriteLine("Введите действия (пустая строка — конец ввода):");

            string line;
            while ((line = Console.ReadLine()) != null && line.Trim() != "")
            {
                string[] parts = line.Split(' ');

                string action = parts[0];

                string prefix, suffix;
                if (action == "MIX") { prefix = "MX"; suffix = "XM"; }
                else if (action == "WATER") { prefix = "WT"; suffix = "TW"; }
                else if (action == "DUST") { prefix = "DT"; suffix = "TD"; }
                else { prefix = "FR"; suffix = "RF"; }

                StringBuilder body = new StringBuilder();
                for (int i = 1; i < parts.Length; i++)
                {
                    string ingredient = parts[i];

                    bool isNumber = true;
                    for (int j = 0; j < ingredient.Length; j++)
                    {
                        if (ingredient[j] < '0' || ingredient[j] > '9')
                        {
                            isNumber = false;
                            break;
                        }
                    }

                    if (isNumber)
                    {
                        int num = Convert.ToInt32(ingredient);
                        body.Append(spells[num - 1]);
                    }
                    else
                    {
                        body.Append(ingredient);
                    }
                }

                spells.Add(prefix + body.ToString() + suffix);
            }

            if (spells.Count > 0)
                Console.WriteLine(spells[spells.Count - 1]);

            Console.ReadLine();
        }
    }
}
