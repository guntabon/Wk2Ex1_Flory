using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex1_Flory
{
    class Program
    {
        static void Main(string[] args)
        {
            double Principal;
            double rate;
            double time;
            
            //This line prompts the user to enter the principal of the loan
            Console.WriteLine("What is principal amount of the loan in dollars?");
            //This line converts the users input into an int variable for use in later formula
            Principal = Convert.ToInt32(Console.ReadLine());
            //this line prompts for the interest rate (which was provided for 5%)
            Console.WriteLine("What is interest rate (input 0.05 for 5%");
            //this line converts the entered number into a double to allow for decimal points
            rate = Convert.ToDouble(Console.ReadLine());
            //Asks for the period of time of the loan in years
            Console.WriteLine("What is period of loan in years?");
            //Converts the period of time entered from a string into an integer
            time = Convert.ToInt32(Console.ReadLine());
            //Is a display for the total value of the loan
            Console.WriteLine("Total interest of Loan:");
            //This takes the previous 3 user entries and multiplies them together while converting as a double in case of decimal points.
            double TotalInterest = Principal * rate * time;
            //This displays the calculated TotalInterest
            Console.WriteLine(TotalInterest);
            //This allows the console to display results and remain unclosed after completion of program
            Console.ReadLine();
            





        }
    }
}
