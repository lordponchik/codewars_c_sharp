/*
7 lvl. Anzahl der Vorkommen
Schreiben Sie eine Funktion, die die Anzahl der Vorkommen eines Elements in einem Array zurückgibt.

Beispiele
var sample = { 1, 0, 2, 2, 3 };
NumberOfOccurrences(0, sample) == 1;
NumberOfOccurrences(4, sample) == 0;
NumberOfOccurrences(2, sample) == 2;
NumberOfOccurrences(3, sample) == 1;
ArraysFundamentals
*/

namespace task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfOccurrences(0, [1, 0, 2, 2, 3]));
            Console.WriteLine(NumberOfOccurrences(4, [1, 0, 2, 2, 3]));
            Console.WriteLine(NumberOfOccurrences(2, [1, 0, 2, 2, 3]));
            Console.WriteLine(NumberOfOccurrences(3, [1, 0, 2, 2, 3]));
        }
        static int NumberOfOccurrences(int x, int[] xs)
        {
            int anzahl = 0;

            foreach (int el in xs)
            {
                if (el == x) anzahl += 1;
            }

            return anzahl;
        }
    }
}
