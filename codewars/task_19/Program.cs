/*
7 lvl. Eindeutige Summe
Bei einer Liste ganzer Werte besteht Ihre Aufgabe darin, die Summe der Werte zurückzugeben. Kommt derselbe ganzzahlige Wert jedoch mehrfach in der Liste vor, kann er nur einmal in der Summe berücksichtigt werden.

Beispiel:

Kata.UniqueSum(new List<int> {1, 2, 3}) => 6

Kata.UniqueSum(new List<int> {1, 3, 8, 1, 8}) => 12

Kata.UniqueSum(new List<int> {-1, -1, 5, 2, -7}) => -1

Kata.UniqueSum(new List<int>()) => null
Viel Erfolg!

ListenLogikFilternGrundlagen
*/

namespace task_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniqueSum([1, 2, 3])); //6
            Console.WriteLine(UniqueSum([1, 3, 8, 1, 8])); //12
            Console.WriteLine(UniqueSum([-1, -1, 5, 2, -7])); //-1
            Console.WriteLine(UniqueSum([])); //null
        }

        static int? UniqueSum(List<int> lst)
        {
            if (lst.Count == 0) return null;

            int ergebnis = 0;

            for (int i = 0; i < lst.Count; i += 1)
            {
                if (i != lst.IndexOf(lst[i]))
                {
                    continue;
                }
                ergebnis += lst[i];
            }

            return ergebnis;
        }
    }
}
