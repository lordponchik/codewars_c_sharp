/*
7 lvl. Berechnen Sie das individuelle Alter zweier Personen
Erstellen Sie eine Funktion, die die Summe und Altersdifferenz zweier Personen berücksichtigt, ihr individuelles Alter berechnet und ein Wertepaar zurückgibt (ältestes Alter zuerst), wenn diese vorhanden sind, oder null/Keine oder {-1, -1} in C, wenn:

Summe < 0
Differenz < 0
Eines der berechneten Alter ist negativ
GrundlagenAlgorithmenArrays
*/

namespace task_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetAges(24, 4)); //14, 10
            Console.WriteLine(GetAges(63, 14)); //38,5 24,5
            Console.WriteLine(GetAges(63, -14)); //null;
        }

        static double[]? GetAges(int sum, int difference)
        {
            double alter1 = (double)(sum + difference) / 2;
            double alter2 = (double)(sum - difference) / 2;

            return sum < 0 || difference < 0 || alter1 < 0 || alter2 < 0 ? null : alter1 > alter2 ? [alter1, alter2] : [alter2, alter1];
        }
    }
}
