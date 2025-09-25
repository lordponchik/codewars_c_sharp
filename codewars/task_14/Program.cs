/*
7 lvl. Gerade oder Ungerade – was ist größer?
Bestätigen Sie anhand einer Ziffernfolge, ob die Summe aller einzelnen geraden Ziffern größer ist als die Summe aller einzelnen ungeraden Ziffern. Es wird immer eine Zahlenfolge ausgegeben.

Wenn die Summe der geraden Zahlen größer ist als die der ungeraden Zahlen, geben Sie zurück: „Gerade ist größer als Ungerade“

Wenn die Summe der ungeraden Zahlen größer ist als die Summe der geraden Zahlen, geben Sie zurück: „Ungerade ist größer als Gerade“

Wenn die Summe der geraden und ungeraden Zahlen identisch ist, geben Sie zurück: „Gerade und Ungerade sind gleich“

Grundlagen
*/

namespace task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvenOrOdd("123")); //"Odd is greater than Even"
            Console.WriteLine(EvenOrOdd("12")); //"Even is greater than Odd"
            Console.WriteLine(EvenOrOdd("112")); //"Even and Odd are the same"
        }

        static string EvenOrOdd(string str)
        {
            int geradeSumme = 0;
            int ungeradeSumme = 0;

            for (int i = 0; i < str.Length; i += 1)
            {
                int elem = int.Parse(str[i].ToString());

                if (elem % 2 == 0) geradeSumme += elem;
                else ungeradeSumme += elem;
            }

            return geradeSumme > ungeradeSumme ? "Even is greater than Odd" : geradeSumme < ungeradeSumme ? "Odd is greater than Even" : "Even and Odd are the same";
        }
    }
}
