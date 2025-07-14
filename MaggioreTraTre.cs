using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    internal class MaggioreTraTre
    {
        public static int Maggiore(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine($"Il numero maggiore tra {num1}, {num2} e {num3} è: {num1}");
                return num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine($"Il numero maggiore tra {num1}, {num2} e {num3} è: {num2}");
                return num2;
            }
            else
            {
                Console.WriteLine($"Il numero maggiore tra {num1}, {num2} e {num3} è: {num3}");
                return num3;
            }
        }
    }
}
