/*
 7 lvl - Fehlendes Element zurückgeben
Lieber Code-Experte, wir brauchen deine Hilfe! Wir haben anscheinend eines unserer Sequenzelemente verloren und brauchen deine Hilfe, um es wiederherzustellen!

Unsere Sequenz sollte alle Ganzzahlen von 0 bis 9 (in beliebiger Reihenfolge) enthalten, aber eines davon scheint zu fehlen.

Schreibe eine Funktion, die eine Folge eindeutiger Ganzzahlen zwischen 0 und 9 (einschließlich) akzeptiert und das fehlende Element zurückgibt.

Beispiele:
[0, 5, 1, 3, 2, 9, 7, 6, 4] --> 8
[9, 2, 4, 5, 7, 0, 8, 6, 1] --> 3
ArraysFundamentals
 */

using System.Linq;

namespace task_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMissingElement([0, 5, 1, 3, 2, 9, 7, 6, 4])); // 8
            Console.WriteLine(GetMissingElement([9, 2, 4, 5, 7, 0, 8, 6, 1])); // 3
        }

        static int GetMissingElement(int[] superImportantArray)
        {
            int[] zahlen = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int gesuchteZahl = 0;

            foreach (int item in zahlen)
            {
                if (!superImportantArray.Contains(item)) gesuchteZahl = item;
            }

            return gesuchteZahl;
        }
    }
}
