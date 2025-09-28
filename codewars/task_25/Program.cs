/*
7 lvl - max diff - einfach
Sie müssen eine Funktion implementieren, die die Differenz zwischen dem größten und dem kleinsten Wert einer als Parameter 
übergebenen Liste/eines Arrays (lst) zurückgibt.

lst enthält Ganzzahlen, d. h. es können auch negative Zahlen enthalten sein.
Wenn lst leer ist oder nur ein Element enthält, wird 0 zurückgegeben.
lst ist nicht sortiert.

[1, 2, 3, 4] // Gibt 3 zurück, da 4 - 1 == 3.
[1, 2, 3, -4] // Gibt 7 zurück, da 3 - (-4) == 7.

Viel Spaß!
 */
using System.Linq;

namespace task_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //v1
            Console.WriteLine(MaxDiff([1, 2, 3, 4])); // 3
            Console.WriteLine(MaxDiff([0, 1, 2, 3, 4, 5, 6])); // 6

            Console.WriteLine(MaxDiff([16])); // 0
            Console.WriteLine(MaxDiff([])); // 0

            Console.WriteLine();
            //v2
            Console.WriteLine(MaxDiff_2([1, 2, 3, 4])); // 3
            Console.WriteLine(MaxDiff_2([0, 1, 2, 3, 4, 5, 6])); // 6

            Console.WriteLine(MaxDiff_2([16])); // 0
            Console.WriteLine(MaxDiff_2([])); // 0
        }

        static int MaxDiff(int[] lst)
        {
            if (lst.Length <= 1) return 0;

            int max = lst[0];
            int min = lst[0];

            foreach (int item in lst)
            {
                if (item > max) max = item;

                if (item < min) min = item;
            }

            return max - min;
        }


        static int MaxDiff_2(int[] lst) => lst.Length <= 1 ? 0 : lst.Max() - lst.Min();

    }
}
