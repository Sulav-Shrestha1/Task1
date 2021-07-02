using System;
using System.Collections.Generic;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Input
            Console.WriteLine("Enter a Letter Between a-z: ");
            string str = Console.ReadLine();

            //Converting into Upper case
            Console.WriteLine("In Upper Case Letter: " + str.ToUpper());
            Console.ReadLine();
        }
    }
}
