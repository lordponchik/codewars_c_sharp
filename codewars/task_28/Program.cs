/*
6 lvl - Englische Bettler
Entstanden aus einer Fehlinterpretation dieses Katas, ist Ihre Aufgabe hier recht einfach: Gegeben sind ein Array von Werten und eine Anzahl von Bettlern. Sie sollen ein Array mit der Summe dessen zurückgeben, was jeder Bettler nach Hause bringt, vorausgesetzt, sie sind alle regelmäßig an der Reihe, vom ersten bis zum letzten.

Beispiel: [1,2,3,4,5] für zwei Bettler ergibt das Ergebnis [9,6], da der erste Bettler [1,3,5] nimmt, der zweite [2,4].

Dasselbe Array mit drei Bettlern hätte wiederum ein besseres Ergebnis für den zweiten Bettler ergeben: [5,7,3], da diese jeweils [1,4], [2,5] und [3] nehmen.

Beachten Sie außerdem, dass nicht alle Bettler die gleiche Anzahl an „Angeboten“ annehmen müssen. Das bedeutet, dass die Länge des Arrays nicht unbedingt ein Vielfaches von n ist; die Länge kann sogar kürzer sein, in diesem Fall nehmen die letzten Bettler natürlich nichts (0).

Hinweis: Falls du nicht verstehst, warum es in diesem Kata um englische Bettler geht, weißt du nicht, wie religiös Warteschlangen im Königreich sind. ;)

Hinweis 2: Das Eingabe-Array nicht verändern.

WarteschlangenArraysListenRekursionGrundlagen
 */

namespace task_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (int item in Beggars([1, 2, 3, 4, 5], 2)) // [9,6]
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (int item in Beggars([1, 2, 3, 4, 5], 3)) // [5,7,3]
            {
                Console.Write(item + " ");
            }
        }

        public static int[] Beggars(int[] values, int n)
        {
            int[] bettler = new int[n];

            if (n == 0) return [];

            for (int i = 0; i < values.Length; i++)
            {
                bettler[i%n] += values[i];
            }

            return bettler;
        }
    }
}
