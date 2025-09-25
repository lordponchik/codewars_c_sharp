/*
7 lvl. Verantwortungsvoller Alkoholkonsum
Willkommen in der Codewars Bar!
Die Codewars Bar empfiehlt, dass Sie pro Standardgetränk 1 Glas Wasser trinken, damit Sie morgen früh keinen Kater haben.

Ihre Programmierkollegen haben Ihnen heute Abend mehrere Getränke in Form einer Zeichenfolge spendiert. Geben Sie eine Zeichenfolge zurück, die vorschlägt, wie viele Gläser Wasser Sie trinken sollten, um keinen Kater zu haben.

Beispiele
„1 Bier“ --> „1 Glas Wasser“
weil Sie ein Standardgetränk getrunken haben

„1 Shot, 5 Biere, 2 Shots, 1 Glas Wein, 1 Bier“ --> „10 Gläser Wasser“
weil Sie zehn Standardgetränke getrunken haben
Hinweis:

Um die Dinge einfach zu halten, betrachten wir jedes „nummerierte Ding“ in der Zeichenfolge als Getränk. Sogar „1 Bär“ -> „1 Glas Wasser“; oder „1 Kettensäge und 2 Pools“ -> „3 Gläser Wasser“...

Grundlagen
*/

namespace task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(hydrate("1 beer")); // "1 glass of water"
            Console.WriteLine(hydrate("1 shot, 5 beers, 2 shots, 1 glass of wine, 1 beer")); // "10 glasses of water"
        }

        static string hydrate(string drinkString)
        {
            // Insert party here

            string[] str = drinkString.Split(" ");
            List<int> anzahl = [];
            int sum;

            foreach (var item in str)
                if (int.TryParse(item, out int res)) anzahl.Add(res);

            sum = anzahl.Sum();

            return sum == 1 ? "1 glass of water" : $"{sum} glasses of water";
        }
    }
}
