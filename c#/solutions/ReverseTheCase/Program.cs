using System;
using System.Linq;

namespace ReverseTheCase
{
    internal class Program
    {
        //ToDo: Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
        //Examples
        //ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"
        //ReverseCase("MANY THANKS") ➞ "many thanks"
        //ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"

        static void Main(string[] args)
        {
            ReverseCase("Happy Birthday");
            ReverseCase("MANY THANKS");
            ReverseCase("sPoNtAnEoUs");
        }

        private static void ReverseCase(string inputTxt)
        {
            char[] charArray = inputTxt.ToCharArray();
            char[] reverseCharArray = new char[charArray.Length];
            
            for (int i = 0; i < charArray.Length; i++)
            {
                bool charIsLower = char.IsLower(charArray[i]);
                if (charIsLower)
                {
                    reverseCharArray[i] = char.ToUpper(charArray[i]);
                }
                else
                {
                    reverseCharArray[i] = char.ToLower(charArray[i]);
                }
            }

            string reversedTxt = new string(reverseCharArray);
            Console.WriteLine(reversedTxt);

        }

    }
}