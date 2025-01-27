using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hypotenuse Calculator!");

            Console.WriteLine("Enter the length of the first side (a): ");
            var a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of the first side (b): ");

            var b = Int32.Parse(Console.ReadLine());

            double hypotenuse = Convert.ToDouble(Math.Sqrt((a * a) + (b * b)));

            Console.WriteLine("The length of the hypotenuse is: " + hypotenuse);

            

            Console.WriteLine("Thank you for using the Hypotenuse Calculator!");

            Console.ReadLine();

        }
    }
}
