/*
 7 lvl - Eindeutige Zeichenketten
In diesem Kata erhalten Sie zwei Zeichenketten a und b. Ihre Aufgabe besteht darin, die Zeichen zu ermitteln, die in den beiden Zeichenketten nicht vorkommen.

Beispiel:

solve("xyab","xzca") = "ybzc"
– Die erste Zeichenkette enthält das Wort „yb“, das in der zweiten nicht vorkommt.
– Die zweite Zeichenkette enthält das Wort „zc“, das in der ersten nicht vorkommt.

Beachten Sie außerdem, dass die Zeichen der ersten Zeichenkette mit denen der zweiten Zeichenkette verknüpft zurückgegeben werden.

Weitere Beispiele finden Sie in den Testfällen.

Viel Erfolg!

Versuchen Sie auch, Duplikate einfach zu entfernen.

StringsFundamentals
 */

namespace task_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solve("xyab", "xzca")); // ybzc
            Console.WriteLine(Solve("abcd", "xyz")); // abcdxyz
        }

        static string Solve(string a, string b)
        {
            string ergebnis = "";

            foreach (var item in a)
                if (!b.Contains(item)) ergebnis += item;

            foreach (var item in b)
                if (!a.Contains(item)) ergebnis += item;

            return ergebnis;
        }
    }
}
