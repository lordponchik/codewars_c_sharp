/*
 7 lvl - Stanton-Maß
Das Stanton-Maß eines Arrays wird wie folgt berechnet:

Zähle die Anzahl der Vorkommen des Werts 1 im Array und setze diese Anzahl mit n.
Das Stanton-Maß gibt an, wie oft n im Array vorkommt.

Schreibe eine Funktion, die ein ganzzahliges Array verarbeitet und dessen Stanton-Maß zurückgibt.

Beispiele
Das Stanton-Maß von [1, 4, 3, 2, 1, 2, 3, 2] ist 3, da 1 2-mal und 2 3-mal im Array vorkommt.

Das Stanton-Maß von [1, 4, 1, 2, 11, 2, 3, 1] ist 1, da 1 3-mal und 3 1-mal im Array vorkommt.

ArraysGrundlagen
 
 */

namespace task_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StantonMeasure(new int[] { 1, 4, 3, 2, 1, 2, 3, 2 })); // 3
            Console.WriteLine(StantonMeasure(new int[] { 1, 4, 1, 2, 11, 2, 3, 1 })); // 1
        }

        static int StantonMeasure(int[] arr)
        {
            int anzahlEins = 0;
            int ergebnis = 0;

            foreach (int item in arr)
                if (item == 1) anzahlEins++;

            foreach (int item in arr)
                if (item == anzahlEins) ergebnis++;

            return ergebnis;
        }
    }
}
