/*
7 lvl. Seltsamer als der Rest
Erstellen Sie eine Methode, die ein Array/eine Liste als Eingabe verwendet und den Index ausgibt, an dem sich die einzige ungerade Zahl befindet.

Diese Methode sollte mit Arrays mit negativen Zahlen funktionieren. Wenn das Array keine ungeraden Zahlen enthält, sollte die Methode -1 ausgeben.

Beispiele:

Kata.OddOne(new List<int> {2,4,6,7,10}) => 3
Kata.OddOne(new List<int> {2,16,98,10,13,78}) => 4
Kata.OddOne(new List<int> {4,-8,98,-12,-7,90,100}) => 4
Kata.OddOne(new List<int> {2,4,6,8}) => -1
Grundlagen
*/

namespace task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OddOne([2, 4, 6, 7, 10])); //3
            Console.WriteLine(OddOne([2, 16, 98, 10, 13, 78])); //4
            Console.WriteLine(OddOne([4, -8, 98, -12, -7, 90, 100])); //4
            Console.WriteLine(OddOne([2, 4, 6, 8])); //-1
        }
        static int OddOne(List<int> list)
        {
            for (int i = 0; i < list.Count; i += 1)
            {
                if (list[i] % 2 == 0) continue;
                return i;
            }

            return -1;
        }
    }
}
