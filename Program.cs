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
        Console.WriteLine("Controllo il numero maggiore tra tre numeri...");
        int num1, num2, num3;
        Console.WriteLine("Inserisci il primo numero:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci il terzo numero:");
        num3 = Convert.ToInt32(Console.ReadLine());
        int maggiore = Metodi.MaggioreTraTre.Maggiore(num1, num2, num3);

        Console.WriteLine("Calcolo la potenza di un numero...");
        double baseNum, exponent;
        Console.WriteLine("Inserisci la base:");
        baseNum = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci l'esponente:");
        exponent = Convert.ToDouble(Console.ReadLine());
        double result = Metodi.Potenza.CalcolaPotenza(baseNum, exponent);

    }
}
