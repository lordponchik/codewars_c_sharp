/*
7 lvl - Liste summieren, aber Duplikate ignorieren
Schreiben Sie eine Funktion, die eine Liste summiert, aber Duplikate ignoriert.

Beispielsweise sollte die Funktion für die Liste [3, 4, 3, 6] den Wert 10 zurückgeben,
und für die Liste [1, 10, 3, 10, 10] den Wert 4.
 */

namespace task_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumNoDuplicates(new int[] { 3, 4, 3, 6 })); //10
            Console.WriteLine(SumNoDuplicates(new int[] { 1, 10, 3, 10, 10 })); //4
        }

        static int SumNoDuplicates(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1 && arr[i] == arr[i + 1]) continue;
                else if (i != 0 && arr[i] == arr[i - 1])  continue;
              
                sum += arr[i];
            }

            return sum;
        }
    }
}
