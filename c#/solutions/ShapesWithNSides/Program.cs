using System;

namespace ShapesWithNSides
{
    internal class Program
    {
        //Create a function that takes a whole number as input and returns the shape with that number's amount of sides. Here are the expected outputs to get from these inputs.
        //
        //Inputs Outputs
        //1	    "circle"
        //2	    "semi-circle"
        //3	    "triangle"
        //4	    "square"
        //5	    "pentagon"
        //6	    "hexagon"
        //7	    "heptagon"
        //8	    "octagon"
        //9	    "nonagon"
        //10	"decagon"
        //Examples:
        //NSidedShape(3) ➞ "triangle"
        //NSidedShape(1) ➞ "circle"
        //NSidedShape(9) ➞ "nonagon"

        static void Main(string[] args)
        {
            Console.WriteLine(NSidedShape(1));
            Console.WriteLine(NSidedShape(2));
            Console.WriteLine(NSidedShape(3));
            Console.WriteLine(NSidedShape(4));
            Console.WriteLine(NSidedShape(5));
            Console.WriteLine(NSidedShape(6));
            Console.WriteLine(NSidedShape(7));
            Console.WriteLine(NSidedShape(8));
            Console.WriteLine(NSidedShape(9));
            Console.WriteLine(NSidedShape(10));
            Console.WriteLine(NSidedShape(11));
            Console.WriteLine(NSidedShape(-1));
        }

        static string NSidedShape(int n)
        {
            string[] outputTxtArr = { "circle", "semi-circle", "triangle", "square", "pentagon", "hexagon", "heptagon", "octagon", "nonagon", "decagon" };
            int outputArrInxd = 0;

            if(n <= 0 || n > 10) 
            {
                return "Invalid number";
            }

            for(int i = 1; i < outputTxtArr.Length; i++)
            {
                
                if(i == n)
                {
                    return outputTxtArr[outputArrInxd];
                }
                outputArrInxd++;

            }
            return "";
        }
    }
}
