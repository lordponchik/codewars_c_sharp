/*
7 lvl. Geisterjäger (Leerzeichen entfernen)
Oh nein! Geister sollen die Stadt überschwemmt haben. Eure Aufgabe ist es, sie zu vertreiben und die Lage zu retten!

In diesem Kata repräsentieren Strings Gebäude, während Leerzeichen darin Geister darstellen.

Worauf wartet ihr also noch? Gibt das Gebäude (String) ohne Geister (Leerzeichen) zurück!

Beispiel:

"Sky scra per" -> "Skyscraper"
Wenn das Gebäude keine Geister enthält, gibt ihr den String zurück:

"Du wolltest doch nur mein Autogramm, oder?"
Grundlagen Reguläre Ausdrücke Strings
*/

namespace task_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GhostBusters("Sky scra per")); //"Skyscraper" 
            Console.WriteLine(GhostBusters("BusStation")); //"You just wanted my autograph didn't you?"
        }

        static string GhostBusters(string building) => building.IndexOf(" ") == -1 ? "You just wanted my autograph didn't you?" : building.Replace(" ", "");
    }
}
