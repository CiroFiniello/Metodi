using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    internal class IsPalindroma
    {
        public static bool IsPali(string input)
        {
                    if (string.IsNullOrEmpty(input))
            {
                return false; // Una stringa vuota o nulla non è considerata palindroma
                Console.WriteLine("La stringa è vuota o nulla.");
            }
            input = input.Trim(); // Rimuove gli spazi iniziali e finali

            input = input.ToLower(); // Converte la stringa in minuscolo

            input = new string(input.Where(c => char.IsLetterOrDigit(c)).ToArray());                     

            return input.SequenceEqual(input.Reverse());
        }
    }
}
