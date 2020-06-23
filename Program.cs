//Made by Joshua Grizzell.

using System;
using Pythagorean;

namespace PTCalculator
{
    class Program
    {
        //Initialization.. (is there a better way to do this?)
        private static double resultA;
        private static double resultB;
        private static string a = null;
        private static string b = null;

        //Main
        static void Main(string[] args)
        {
            var pyth = new Pyth();
            
            while(pyth.response == "Y" || pyth.response == "y")
            {
                System.Console.WriteLine("\nPlease input a value for the 'a' variable.");
                resultA = pyth.GetVar(a);
                System.Console.WriteLine("\nPlease input a value for the 'b' variable.");
                resultB = pyth.GetVar(b);

                double finalresult = Math.Sqrt((Math.Pow(resultA, 2)) + (Math.Pow(resultB, 2)));
                Console.WriteLine($"c = {finalresult:N2}");

                pyth.CalculateAgain();
            }

            
        }
        
    }


}
