/*
7 lvl. Wie viele aufeinanderfolgende Zahlen werden benötigt?
Schreiben Sie eine Funktion, die ein Array eindeutiger Ganzzahlen verwendet und die Mindestanzahl an Ganzzahlen zurückgibt, die erforderlich ist, um die Werte des Arrays von der niedrigsten bis zur höchsten Zahl aufeinander folgen zu lassen.

Beispiel
[4, 8, 6] --> 2
Weil 5 und 7 addiert werden müssen, um [4, 5, 6, 7, 8] zu erhalten

[-1, -5] --> 3
Weil -2, -3, -4 addiert werden müssen, um [-5, -4, -3, -2, -1] zu erhalten

[1] --> 0
[] --> 0
ArraysFundamentals
*/

namespace task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Consecutive([4, 8, 6])); // 2
            Console.WriteLine(Consecutive([-1, -5])); // 3
            Console.WriteLine(Consecutive([1])); // 0
            Console.WriteLine(Consecutive([])); // 0
        }

        static int Consecutive(int[] arr)
        {
            if (arr.Length == 0 || arr.Length == 1) return 0;

            int[] newArr = (int[])arr.Clone();
            Array.Sort(newArr);

            int minZahl = newArr[0];
            int maxZahl = newArr[newArr.Length - 1];

            List<int> res = [];

            for (int i = minZahl; i <= maxZahl; i += 1)
                 res.Add(i);

            return res.Count - newArr.Length;
        }
    }
}
