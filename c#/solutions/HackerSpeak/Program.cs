using System;

namespace HackerSpeak
{
    //Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.
    //HackerSpeak("javascript is cool") ➞ "j4v45cr1pt 15 c00l"
    //HackerSpeak("programming is fun") ➞ "pr0gr4mm1ng 15 fun"
    //HackerSpeak("become a coder") ➞ "b3c0m3 4 c0d3r"
    //Hints:
    //In order to work properly, the function should replace all "a"s with 4, "e"s with 3, "i"s with 1, "o"s with 0, and "s"s with 5.
    internal class Program
    {
        static void Main(string[] args)
        {
            HackerSpeak("javascript IS COOL");
            HackerSpeak("programming is fun");
            HackerSpeak("become a coder");
        }

        private static void HackerSpeak(string inputTxt)
        {
            string outputTxt = inputTxt.ToLower().Replace("a", "4").Replace("e", "3").Replace("i", "1").Replace("o", "0").Replace("s", "5");
            Console.WriteLine(outputTxt);
        }

    }
}
