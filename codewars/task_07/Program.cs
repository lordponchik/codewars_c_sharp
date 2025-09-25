/*
7 lvl. Regexp-Grundlagen – ist es ein Vokal?
Implementieren Sie die Funktion, die „true“ zurückgeben soll, wenn das angegebene Objekt ein Vokal ist (also a, e, i, o, u, Groß- oder Kleinbuchstabe), 
und andernfalls „false“.

Reguläre AusdrückeGrundlagen
*/

using System.Text.RegularExpressions;

namespace task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Vowel("Niks")); // false;
            Console.WriteLine(Vowel("")); //  false
            Console.WriteLine(Vowel("e")); //  true
            Console.WriteLine(Vowel("E")); //  true
        }

        static bool Vowel(string s) => s.Length > 1 ? false : Regex.IsMatch(s.ToLower(), "[aeiou]");
    }
}
