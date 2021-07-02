using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Tasks
{
    class CSV
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Value: ");
            string a = Console.ReadLine();

            int input = Convert.ToInt32(a);

            //Example = 1,000,000
            //string output = String.Format("{0:#,#}", input);

            //Example = 1,00,000
            string output = input.ToString("#,#", new CultureInfo(0x0439));
            
            //Example = 1,00,000.00
            //string output = input.ToString("#,#.##", new CultureInfo(0x0439));



            Console.WriteLine("The comma separated value is : " + output);
            Console.ReadLine();

        }
    }
}
