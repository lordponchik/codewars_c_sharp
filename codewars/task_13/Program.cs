/*
8 lvl. Neues Element hinzufügen (Sammlungen werden per Referenz übergeben)
Ein Element zur Liste hinzufügen:

Die Methode AddExtra fügt ein neues Element zur Liste hinzu und gibt die Liste zurück. Das neue Element kann ein beliebiges Objekt sein, das spielt keine Rolle. (Nehmen wir an, Sie fügen einen ganzzahligen Wert hinzu, z. B. 13)

In unserem Testfall prüfen wir, ob die zurückgegebene Liste ein Element mehr enthält als die Eingabeliste. Die Methode muss jedoch etwas geändert werden, um diesen Test zu bestehen.

P.S. Sie müssen eine neue Liste erstellen und dieser ein neues Element hinzufügen. (Dieses Kata wurde ursprünglich für die Sprache C# entwickelt und zeigt, dass das Hinzufügen eines neuen Elements zur Eingabeliste nicht funktioniert, obwohl der Parameter per Wert übergeben wird, der Wert jedoch auf die Referenz der Liste verweist und jede Änderung des Parameters vom Anrufer gesehen wird)

Grundlagen
*/

namespace task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (int item in AddExtra([]))
            {
                Console.WriteLine(item);
            } //[1]
        }

        static List<int> AddExtra(List<int> listOfNumbers)
        {
            listOfNumbers.Add(1);

            return listOfNumbers;
        }
    }
}
