/*
7 lvl. Briefkasten-Maltrupp
Quelle: imgur.com
Geschichte
Sie und eine Gruppe von Freunden verdienen in den Schulferien etwas zusätzliches Geld, indem Sie gegen eine geringe Gebühr die Nummern auf den Briefkästen anderer Leute neu bemalen.

Da Sie zu zehnt in der Gruppe sind, konzentriert sich jeder auf das Bemalen einer Ziffer! Zum Beispiel malt jemand nur die 1er, jemand anderes nur die 2er und so weiter...

Aber am Ende des Tages stellen Sie fest, dass nicht jeder gleich viel Arbeit geleistet hat.

Um Streit zu vermeiden, müssen Sie das Geld gerecht verteilen. Und hier kommt diese Kata ins Spiel.

Kata-Aufgabe
Schreiben Sie anhand der Start- und Endnummern der Briefkästen eine Methode, um die Häufigkeit aller 10 bemalten Ziffern zurückzugeben.

Beispiel
Für Start = 125 und Ende = 132

Die Buchstabenfelder sind

125 = 1, 2, 5
126 = 1, 2, 6
127 = 1, 2, 7
128 = 1, 2, 8
129 = 1, 2, 9
130 = 1, 3, 0
131 = 1, 3, 1
132 = 1, 3, 2
Die Ziffernhäufigkeiten sind:

0 wird 1 Mal gemalt
1 wird 9 Mal gemalt
2 wird 6 Mal gemalt
usw.
und daher würde die Methode [1,9,6,3,0,1,1,1,1,1] zurückgeben

Hinweise
0 < Start <= Ende
In C wird der zurückgegebene Wert freigegeben.
Grundlagen
*/

namespace task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (int item in PaintLetterBoxes(125, 132))
            {
                Console.Write(item + " ");
            } // {1,9,6,3,0,1,1,1,1,1}
        }

        static IEnumerable<int> PaintLetterBoxes(int start, int end)
        {
            int[] arbeitsAufwandar = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            List<int> arrInt = [];


            for (int i = start; i <= end; i += 1)
                arrInt.Add(i);


            arrInt = string.Join("", arrInt).Select(el => int.Parse(el.ToString())).ToList();

            foreach (int item in arrInt)
                arbeitsAufwandar[item] += 1;


            return arbeitsAufwandar;
        }
    }
}
