using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex2__Flory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the Length of the rectangle: ");

            var length = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the width of the rectangle: ");

            var width = int.Parse(Console.ReadLine());

            Console.WriteLine("Results: ");
            var area = length * width;
            
           
            Console.WriteLine("Area of the rectangle: " + area);

            var perimeter = (width * 2) + (length * 2);

            Console.WriteLine(perimeter);

            Console.ReadLine();
        }
    }
}
