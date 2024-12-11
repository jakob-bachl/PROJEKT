using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        var leftList = new List<long>();
        var rightList = new List<long>();

        // einlesen der daten 
        foreach (var line in File.ReadLines("input.txt"))
        {
            // Teile die Zeile an Leerzeichen
            var parts = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

            // Prüfe ob genau zwei Werte gefunden wurden
            if (parts.Length == 2)
            {
                if (long.TryParse(parts[0], out long leftVal) &&
                    long.TryParse(parts[1], out long rightVal))
                {
                    leftList.Add(leftVal);
                    rightList.Add(rightVal);
                }
            }
        }

        // Sortiere beide Listen
        leftList.Sort();
        rightList.Sort();

        // Berechne die Summe der absoluten Differenzen
        long totalDistance = 0;
        for (int i = 0; i < leftList.Count && i < rightList.Count; i++)
        {
            totalDistance += Math.Abs(leftList[i] - rightList[i]);
        }

        // Ergebnis ausgeben
        Console.WriteLine(totalDistance);
    }
}