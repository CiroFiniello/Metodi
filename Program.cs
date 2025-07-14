//✅ Funzioni con parametri e ritorno

//Funzione che controlla se una stringa è palindroma

//Funzione che restituisce il numero maggiore tra tre

//Funzione per calcolare la potenza base^esponente




using System;
using System.Collections;
class Program
{
    static void Main()
    {
        Console.WriteLine("Controllo se la stringa è palindroma...");
        string input = "";
        input = Console.ReadLine();
        if (Metodi.IsPalindroma.IsPali(input))
        {
            Console.WriteLine("La stringa è palindroma.");
        }
        else
        {
            Console.WriteLine("La stringa non è palindroma.");
        }
    }
}
