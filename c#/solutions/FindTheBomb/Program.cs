using System;

namespace FindTheBomb
{
    internal class Program
    {
        //ToDo: Create a function that finds the word "bomb" in the given string (not case sensitive). If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".
        //Examples:
        //Bomb("There is a bomb.") ➞ "Duck!!!"
        //Bomb("Hey, did you think there is a bomb?") ➞ "Duck!!!"
        //Bomb("This goes boom!!!") ➞ "There is no bomb, relax."
        //"bomb" may appear in different cases (i.e. uppercase, lowercase, mixed).

        static void Main(string[] args)
        {
            Bomb("There is a bomb.");
            Bomb("Hey, did you think there is a bomb?");
            Bomb("This goes boom!!!");
        }

        private static void Bomb(string inputTxt)
        {
            string[] words = inputTxt.Split(" ");
            foreach (string word in words)
            {
                if(word.ToLower().Contains("bomb"))
                {
                    Console.WriteLine("Duck!!!");
                    return;
                }
            }
            Console.WriteLine("There is no bomb, relax.");
        }

    }
}
