/*
7 lvl. Wort in Zeichenfolge multiplizieren
Sie sollen eine Funktion schreiben, die als ersten Parameter eine Zeichenfolge verwendet. Diese Zeichenfolge ist eine Zeichenfolge aus Wörtern.

Sie sollen dann den zweiten Parameter, der eine Ganzzahl ist, verwenden, um das entsprechende Wort in der angegebenen Zeichenfolge zu finden. Das erste Wort wird durch 0 dargestellt.

Sobald Sie die gefundene Zeichenfolge haben, multiplizieren Sie schließlich den dritten bereitgestellten Parameter, der ebenfalls eine Ganzzahl ist. Sie müssen zusätzlich zwischen jedem Wort einen Bindestrich einfügen.

Beispiel

modifyMultiply („Dies ist eine Zeichenfolge“, 3, 5)
ZeichenfolgenAlgorithmenGrundlagenArrays
*/

namespace task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ModifyMultiply("is very easy to resolve that kata", 0, 3)); //is-is-is
            Console.WriteLine(ModifyMultiply("Talk is cheap Show me the code", 2, 4)); //cheap-cheap-cheap
        }

        static string ModifyMultiply(string str, int loc, int num)
        {
            string suchbegriff = str.Split(" ")[loc];
            List<string> massiv = [];

            for (int i = 0; i < num; i++)
                massiv.Add(suchbegriff);

            return string.Join("-", massiv);
        }
    }
}
