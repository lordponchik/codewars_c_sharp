/*
7 lvl. Originalpreis ermitteln
Wir benötigen Code, um den Originalpreis eines Produkts zu ermitteln. Der Rückgabetyp muss Dezimal sein und die Zahl muss auf zwei Dezimalstellen gerundet sein.

Wir erhalten den Verkaufspreis (Rabattpreis) und den Rabattprozentsatz. Unsere Aufgabe ist es, den Originalpreis zu ermitteln.

Beispiel:
Bei einem Artikel zum Verkaufspreis von 75 $ nach Abzug von 25 % Rabatt soll die Funktion den Originalpreis dieses Artikels vor Abzug des Rabattprozentsatzes (100,00 $) zurückgeben, natürlich gerundet auf zwei Dezimalstellen.

DiscoverOriginalPrice(75, 25) => 100.00M, wobei 75 der Verkaufspreis (Rabattpreis), 25 der Rabattprozentsatz und 100 der Originalpreis ist.

Grundlagen der Mathematik
*/

namespace task_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DiscoverOriginalPrice(75M, 25M)); //100,00M
            Console.WriteLine(DiscoverOriginalPrice(16M, 45M)); //29,09M
        }

        static decimal DiscoverOriginalPrice(decimal discountedPrice, decimal salePercentage) => Math.Round(discountedPrice * 100 / (100 - salePercentage), 2);
    }
}
