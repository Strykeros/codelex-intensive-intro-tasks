using System;
using System.Linq;

namespace ShuffleTheName
{
    internal class Program
    {
        //Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.
        //NameShuffle("Donald Trump") ➞ "Trump Donald"
        //NameShuffle("Rosie O'Donnell") ➞ "O'Donnell Rosie"
        //NameShuffle("Seymour Butts") ➞ "Butts Seymour"
        //Hint:
        //There is exactly one space between the first and last name.
        static void Main(string[] args)
        {
            Console.WriteLine(NameShuffle("Donald Trump"));
            Console.WriteLine(NameShuffle("Rosie O'Donnell"));
            Console.WriteLine(NameShuffle("Seymour Butts"));
        }

        private static string NameShuffle(string inputName)
        {
            return string.Join(' ', inputName.Split(' ').Reverse());
        }

    }
}
