/*
7 lvl - Inspirierende Strings
Bei einer Zeichenfolge mit durch Leerzeichen getrennten Wörtern wird das längste Wort zurückgegeben.
Bei mehreren längsten Wörtern wird das am weitesten rechts stehende längste Wort zurückgegeben.

Beispiele
"rot weiß blau" => "weiß"
"rot blau gold" => "gold"
StringsFundamentals
 */

using System.Linq;

namespace task_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestWord("red white blue")); // white
            Console.WriteLine(LongestWord("a b c d e fgh")); // fgh
            Console.WriteLine(LongestWord("red blue gold")); // gold
        }

        static string LongestWord(string stringOfWords) => stringOfWords.Split(" ").Aggregate((letzte, naechst) => naechst.Length >= letzte.Length ? naechst : letzte);
    }
}
