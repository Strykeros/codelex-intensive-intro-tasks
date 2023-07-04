using System;
using System.Linq;

namespace SymmetricalNumber
{
    internal class Program
    {
        //ToDo: Create a function that takes a number as an argument and returns true or false depending on whether the number is symmetrical or not. A number is symmetrical when it is the same as its reverse.
        //Examples:
        //IsSymmetrical(7227) ➞ true
        //IsSymmetrical(12567) ➞ false
        //IsSymmetrical(44444444) ➞ true
        //IsSymmetrical(9939) ➞ false
        //IsSymmetrical(1112111) ➞ true

        static void Main(string[] args)
        {
            Console.WriteLine(IsSymmetrical(7227));
            Console.WriteLine(IsSymmetrical(1234567));
            Console.WriteLine(IsSymmetrical(44444444));
            Console.WriteLine(IsSymmetrical(9939));
            Console.WriteLine(IsSymmetrical(1112111));
        }

        private static bool IsSymmetrical(int n)
        {
            char[] numberArray = n.ToString().ToCharArray();
            char[] reversedArr = numberArray.Reverse().ToArray();

            return numberArray.AsQueryable().SequenceEqual(reversedArr);

        }

    }
}
