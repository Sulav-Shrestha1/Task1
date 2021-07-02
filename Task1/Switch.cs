using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Digit: ");
            int i = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Enter Any of the Given Choices");
            Console.WriteLine("I - Convert from Inches to Centimeters");
            Console.WriteLine("G - Convert from Gallons to Liters");
            Console.WriteLine("M - Convert from Mile to Kilometer");
            Console.WriteLine("P - Convert from Pound to kilogram");
            string ans = Console.ReadLine().ToUpper();

            switch (ans)
            {
                case "I":
                    double d = i * 2.54;
                    Console.WriteLine("{0} Inches is {1} Centimeters", i, d);
                    Console.ReadLine();
                    break;
                case "G":
                    double d1 = i * 3.78541;
                    Console.WriteLine("{0} Gallons is {1} Liters", i, d1);
                    Console.ReadLine();
                    break;
                case "M":
                    double d2 = i * 1.60934;
                    Console.WriteLine("{0} Mile is {1} Kilometer", i, d2);
                    Console.ReadLine();
                    break;
                case "P":
                    double d3 = i * 0.453592;
                    Console.WriteLine("{0} Pound is {1} Kilogram", i, d3);
                    Console.ReadLine();
                    break;

            }
        }
    }
}
