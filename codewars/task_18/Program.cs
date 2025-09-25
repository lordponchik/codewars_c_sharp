/*
7 lvl. Punktrechner
Punktrechner
Sie müssen einen Rechner schreiben, der Zeichenketten als Eingabe empfängt. Die Punkte stellen die Zahl in der Gleichung dar. Auf der einen Seite stehen Punkte, auf der anderen Seite ein Operator und nach dem Operator wieder Punkte. Punkte und Operator sind durch ein Leerzeichen getrennt.

Die folgenden Operatoren sind gültig:

+ Addition
- Subtraktion
* Multiplikation
// Ganzzahldivision
Ihre Aufgabe
Sie müssen eine Zeichenkette mit so vielen Punkten zurückgeben, wie die Gleichung zurückgibt. Ist das Ergebnis 0, geben Sie die leere Zeichenkette zurück. Bei einer Subtraktion ist die erste Zahl immer größer oder gleich der zweiten Zahl.

Beispiele (Eingabe => Ausgabe)
* "..... + ..............." => "......"
* "..... - ..." => ".."
* "..... - ." => "...."
* "..... * ..." => "................."
* "..... * .." => ".........."
* "..... // .." => ".."
* "..... // ." => "..."
* ". // .." => ""
* ".. - .." => ""
StringsFundamentals
*/


namespace task_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator("..... + ...............")); //"...................."
            Console.WriteLine(Calculator("..... - ...")); //".."
            Console.WriteLine(Calculator("..... - .")); //"...."
            Console.WriteLine(Calculator("..... * ...")); //"..............."
            Console.WriteLine(Calculator("..... // ..")); //".."
            Console.WriteLine(Calculator(". // ..")); //""
            Console.WriteLine(Calculator(".. - ..")); //"" 
        }

        static string Calculator(string txt)
        {
            string[] arr = txt.Split(" ");
            int operand_1 = arr[0].Length;
            int operand_2 = arr[2].Length;
            string operator_1 = arr[1];
            int ergebnis = 0;
            string ergebnisInPunkte = "";

            switch (operator_1)
            {
                case "+":
                    ergebnis = operand_1 + operand_2;
                    break;
                case "-":
                    ergebnis = operand_1 - operand_2;
                    break;
                case "*":
                    ergebnis = operand_1 * operand_2;
                    break;
                case "//":
                    ergebnis = operand_1 / operand_2;
                    break;
                default:
                    Console.WriteLine("Fehler");
                    break;
            }

            for (int i = 1; i <= ergebnis; i += 1)
            {
                ergebnisInPunkte += ".";
            }

            return ergebnisInPunkte;
        }
    }
}
