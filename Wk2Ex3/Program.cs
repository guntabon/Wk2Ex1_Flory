using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Temperature Converter");
            Console.WriteLine("Enter the Temperature: ");
            var temperature = Int32.Parse(Console.ReadLine());
            var conversion = Convert.ToDouble((temperature - 32) * 5/9);
            Console.WriteLine(temperature + "°F is equivalent to " + conversion + "°C");
            Console.ReadLine();
        }
    }
}
