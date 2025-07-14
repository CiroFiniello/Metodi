using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    internal class Potenza
    {
        public static double CalcolaPotenza(double baseNum, double exponent)
        {
            if (exponent < 0)
            {
                Console.WriteLine("L'esponente deve essere un numero non negativo.");
                return -1; // Indica un errore
            }
            double result = Math.Pow(baseNum, exponent);
            Console.WriteLine($"La potenza di {baseNum} elevato a {exponent} è: {result}");
            return result;
        }
    }
}
