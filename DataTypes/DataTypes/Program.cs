using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */
            // Console.Writeline is print
            Console.WriteLine("What is your name?");
            // Console.Write is an input
            Console.Write("Please enter your first name: ");
            string myFirstName = Console.ReadLine();

            Console.Write("Your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();



        }
    }
}
