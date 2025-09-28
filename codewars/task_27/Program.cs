/*
7 lvl - Aufeinanderfolgende Elemente
Sie erhalten eine Liste eindeutiger Ganzzahlen arr sowie zwei Ganzzahlen a und b. Ihre Aufgabe besteht darin, herauszufinden, ob a und b in arr aufeinanderfolgen, und einen booleschen Wert zurückzugeben (Wahr, wenn a und b aufeinanderfolgen, andernfalls Falsch).

Es ist garantiert, dass a und b beide in arr vorkommen.
 */

namespace task_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Consecutive(new int[] { 1, 3, 5, 7 }, 3, 7)); //false
            Console.WriteLine(Consecutive(new int[] { 1, 3, 5, 7 }, 3, 1)); //true
            Console.WriteLine(Consecutive(new int[] { 1, 6, 9, -3, 4, -78, 0 }, -3, 4)); //true
        }

        static bool Consecutive(int[] arr, int a, int b)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                if (arr[i] == a && arr[i + 1] == b || arr[i] == b && arr[i + 1] == a) return true;

            return false;
        }
    }
}
