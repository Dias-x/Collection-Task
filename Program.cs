using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Liste erstellen
        List<string> names = new List<string>();

        //Werte hinzufügen
        names.Add("Peter");
        names.Add("Alina");
        names.Add("Sabine");
        names.Add("Florian");

        Console.WriteLine("Unsortiert");
        Console.WriteLine("--------------------------");
        
        //Schleife laufen lassen
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();
        
        Console.WriteLine("Sortiert");
        Console.WriteLine("--------------------------");
        
        //Methode abrufen
        ListSort();
        //Schleife laufen lassen
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        
        //Methode mit Sortieren erstellen
        void ListSort()
        {
            names.Sort();
        }
    }
}