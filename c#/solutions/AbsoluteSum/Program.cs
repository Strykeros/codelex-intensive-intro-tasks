using System;

namespace AbsoluteSum
{
    internal class Program
    {
        // ToDo: Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.
        //Examples:
        //GetAbsSum([2, -1, 4, 8, 10]) ➞ 25
        //GetAbsSum([-3, -4, -10, -2, -3]) ➞ 22
        //GetAbsSum([2, 4, 6, 8, 10]) ➞ 30
        //GetAbsSum([-1]) ➞ 1

        //The term "absolute value" means to remove any negative sign in front of a number, and to think of all numbers as positive (or zero).
        //All the elements in the given array are integers.
        static void Main(string[] args)
        {
            int[] testArr = { 2, -1, 4, 8, 10 };
            int[] testArr2 = { -3, -4, -10, -2, -3 };
            int[] testArr3 = { 2, 4, 6, 8, 10 };
            int[] testArr4 = { -1 };
            GetAbsSum(testArr);
            GetAbsSum(testArr2);
            GetAbsSum(testArr3);
            GetAbsSum(testArr4);
        }

        private static void GetAbsSum(int[] inputArr)
        {
            int sum = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                sum += Math.Abs(inputArr[i]);
            }
            Console.WriteLine(sum);
        }

    }
}
