/*
7 lvl. SevenAte9
Schreiben Sie eine Funktion, die jede einzelne 9 zwischen 7en entfernt.

"79712312" -> "7712312"
"79797" -> "777"
LogicStringsFundamentals
*/

namespace task_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SevenAteNine("79712312")); //"7712312"
            Console.WriteLine(SevenAteNine("79797")); //"777"
            Console.WriteLine(SevenAteNine("9797")); //"977"
            Console.WriteLine(SevenAteNine("97979")); //"9779"
        }

        static string SevenAteNine(string str)
        {
            string neuStr = "";

            for (int i = 0; i < str.Length; i += 1)
            {
                if (str[i] == '9' && i != 0 && i != str.Length - 1)
                {
                    if (str[i - 1] == '7' && str[i + 1] == '7') continue;
                }

                neuStr += str[i];
            }

            return neuStr;
        }
    }
}
