/*
7 lvl. Skalieren von quadrierten Zeichenfolgen
Sie erhalten eine Zeichenfolge mit n Zeilen, wobei jede Teilzeichenfolge n Zeichen lang ist. Beispiel:

s = "abcd\nefgh\nijkl\nmnop"

Wir werden die "horizontale" und die "vertikale" Skalierung dieses Zeichenfolgenquadrats untersuchen.

Eine k-horizontale Skalierung einer Zeichenfolge besteht aus der k-fachen Replikation jedes Zeichens der Zeichenfolge (außer '\n').

Beispiel: 2-horizontale Skalierung von s: => "aabbccdd\neeffgghh\niijjkkll\nmmnnoopp"
Eine v-vertikale Skalierung einer Zeichenfolge besteht aus der v-fachen Replikation jedes Teils der quadrierten Zeichenfolge.

Beispiel: 2-vertikale Skalierung von s: => "abcd\nabcd\nefgh\nefgh\nijkl\nijkl\nmnop\nmnop"
Die Funktion scale(strng, k, v) führt eine k-horizontale Skalierung und eine v-vertikale Skalierung durch.

Beispiel: a = "abcd\nefgh\nijkl\nmnop"
scale(a, 2, 3) --> "aabbccdd\naabbccdd\naabbccdd\neeffgghh\neeffgghh\neeffgghh\niijjkkll\niijjkkll\niijjkkll\nmmnnoopp\nmmnnoopp\nmmnnoopp"
Gedruckt:

abcd\nefgh\nijkl\nmnop -----> aabbccdd\naabbccdd\naabbccdd\neeffgghh\neeffgghh\neeffgghh\niijjkkll\niijjkkll\niijjkkll\nmmnnoopp\nmmnnoopp\nmmnnoopp
Aufgabe:
Schreiben Sie die Funktion scale(strng, k, v), k und v sind positive ganze Zahlen. Wenn strng == "" return "".
GrundlagenStrings
*/

namespace task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Scale("abcd\nefgh\nijkl\nmnop", 2, 3)); // aabbccdd\naabbccdd\naabbccdd\neeffgghh\neeffgghh\neeffgghh\niijjkkll\niijjkkll\niijjkkll\nmmnnoopp\nmmnnoopp\nmmnnoopp
        }

        static string Scale(string strng, int k, int n)
        {
            if (strng.Length == 0) return "";

            string[] arr = strng.Split("\n");
            for (int item = 0; item < arr.Length; item++)
            {
                string str = "";

                for (int i = 0; i < arr[item].Length; i++)
                {

                    for (int j = 0; j < k; j++)
                    {
                        str += arr[item][i];
                    }

                }
                arr[item] = str;

            }

            List<string> neuArr = [];

            foreach (var item in arr)
            {
                for (int i = 0; i < n; i++)
                {
                    neuArr.Add(item);
                }
            }

            return string.Join("\n", neuArr);
        }
    }
}
