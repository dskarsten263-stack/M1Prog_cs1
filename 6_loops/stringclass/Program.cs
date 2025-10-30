using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;

namespace stringclass;

class Program
{
    static void Main(string[] args)
    {
        string voorbeeld = "voorbeeld string";
        Console.WriteLine(voorbeeld);
        Console.WriteLine(voorbeeld.Length);
        Console.WriteLine(voorbeeld.ToUpper());

        string[] geenCaps = { "global", "variabele", "class" };

        foreach (string woord in geenCaps)
        {
            Console.WriteLine(woord);
            Console.WriteLine($"is een string die { woord.Length} lang is ");
            Console.WriteLine(woord.ToUpper());
            
            
        }


        }
}
