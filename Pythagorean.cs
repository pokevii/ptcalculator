using System;

namespace Pythagorean
{
    public class Pyth
    {
        public Pyth()
        {
            response = "Y";
        }

        public double GetVar(string x)
        {
            while(true)
            {
                try
                {
                    x = Console.ReadLine();
                    resultA = double.Parse(x);
                    return resultA;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Argument exception. Returning 0.");
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please input a number this time!\n");
                    continue;
                }          
            }  
        }

        public void CalculateAgain()
        {
            System.Console.WriteLine("\nWould you like to calculate another solution? (Y/N)");
            response = Console.ReadLine();
            while(true)
            {
                if(response == "N" || response == "n")
                    {
                        break;
                    }
                else if(response == "Y" || response == "y")
                    {
                        total += 1;
                        if(total == 1)
                        {
                            Console.WriteLine($"Restarting. So far you've calculated the Pythagorean Theorem {total} time!");
                        }
                        if(total > 1)
                        {
                            Console.WriteLine($"Restarting. So far you've calculated the Pythagorean Theorem {total} times!");
                        }
                        break;
                    }
                else
                    {
                        System.Console.WriteLine("Invalid response. Try again! (Y/N)");
                        response = Console.ReadLine();  
                    }
            }
        }

        //Properties & Fields

        private double _resultA;
        public double resultA
        {
            get { return _resultA; }
            set { _resultA = value; }
        }
        
        public string response;
        private int total = 0;
    }
}