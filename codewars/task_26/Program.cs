/*
7 lvl - Gültige Abstände
Aufgabe
Ihre Aufgabe besteht darin, eine Funktion namens valid_spacing() oder validSpacing() zu schreiben, die prüft, ob ein String gültige Abstände hat. Die Funktion sollte entweder „true“ oder „false“ (oder den entsprechenden Wert in der jeweiligen Sprache) zurückgeben.

Für dieses Kata ist ein gültiger Abstand ein Leerzeichen zwischen Wörtern und keine führenden oder nachfolgenden Leerzeichen. Wörter können eine beliebige Folge von Zeichen ohne Leerzeichen sein. Nachfolgend einige Beispiele für die Rückgabewerte der Funktion:

* „Hallo Welt“ => „true“
* „Hallo Welt“ => „false“
* „Hallo Welt“ => „false“
* „Hallo Welt“ => „false“
* „Hallo“ => „true“

Auch ohne Leerzeichen ist die Funktion gültig, da keine benötigt werden:
* „Hallo Welt“ => „true“
* „Hallo Welt“ => „false“
* „ „ „ => „true“
* „ „ „ => „true“
Hinweis: Der Eingabestring enthält keine Satzzeichen oder Ziffern, sondern nur Buchstaben.

Grundlagen
 */

namespace task_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidSpacing("Hello world")); ; //true
            Console.WriteLine(ValidSpacing(" Hello world")); ; //false
            Console.WriteLine(ValidSpacing("Hello world ")); ; //false
            Console.WriteLine(ValidSpacing("Hello  world")); ; //false
            Console.WriteLine(ValidSpacing("Hello  world")); ; //false
            Console.WriteLine(ValidSpacing(" ")); ; //false
            Console.WriteLine(ValidSpacing("")); ; //true
        }

        static bool ValidSpacing(string s)
        {
            char[] chars = s.ToCharArray();

            if (string.IsNullOrEmpty(s)) return true;
            if (s.Length == 1 && chars[0] == ' ') return false;
            if (chars[0] == ' ' || chars[s.Length - 1] == ' ') return false;

            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == ' ' && chars[i + 1] == ' ') return false;
            }

            return true;
        }

    }
}