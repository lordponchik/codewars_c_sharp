/* 
7 lvl. Unscrambled eggs
Unscramble the eggs.

The string given to your function has had an "egg" inserted directly after each consonant. You need to return the string before it became eggcoded.

Example
unscrambleEggs("Beggegeggineggneggeregg")  =>  "Beginner"
//             "B---eg---in---n---er---"
Kata is supposed to be for beginners to practice reggular eggspressions, so commenting would be appreciated.

Fundamentals
*/

namespace task_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UnscrambleEggs("Beggegeggineggneggeregg")); // "Beginner"
            Console.WriteLine(UnscrambleEggs("ceggodegge heggeregge")); //"code here"
            Console.WriteLine(UnscrambleEggs("FeggUNegg KeggATeggA")); //"FUN KATA"
        }

        static string UnscrambleEggs(string word) => word.Replace("egg", "");
    }
}
