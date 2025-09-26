/*
7 lvl - max diff - easy
You must implement a function that returns the difference between the largest and the smallest value in a given list / array (lst) received as the parameter.

lst contains integers, that means it may contain some negative numbers
if lst is empty or contains a single element, return 0
lst is not sorted
[1, 2, 3, 4]   //  returns 3 because 4 -   1  == 3
[1, 2, 3, -4]  //  returns 7 because 3 - (-4) == 7
Have fun!

MathematicsListsArraysFundamentals
 */
using System.Linq;

namespace task_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //v1
            Console.WriteLine(MaxDiff([1, 2, 3, 4])); // 3
            Console.WriteLine(MaxDiff([0, 1, 2, 3, 4, 5, 6])); // 6

            Console.WriteLine(MaxDiff([16])); // 0
            Console.WriteLine(MaxDiff([])); // 0

            Console.WriteLine();
            //v2
            Console.WriteLine(MaxDiff_2([1, 2, 3, 4])); // 3
            Console.WriteLine(MaxDiff_2([0, 1, 2, 3, 4, 5, 6])); // 6

            Console.WriteLine(MaxDiff_2([16])); // 0
            Console.WriteLine(MaxDiff_2([])); // 0
        }

        static int MaxDiff(int[] lst)
        {
            if (lst.Length <= 1) return 0;

            int max = lst[0];
            int min = lst[0];

            foreach (int item in lst)
            {
                if (item > max) max = item;

                if (item < min) min = item;
            }

            return max - min;
        }


        static int MaxDiff_2(int[] lst) => lst.Length <= 1 ? 0 : lst.Max() - lst.Min();

    }
}
