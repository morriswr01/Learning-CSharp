using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Please type something acnpress the enter key:");
            //string userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);
            //Console.ReadLine();

            Console.WriteLine("Would you prefer what is behind door number 1,2 or 3?");
            string userValue = Console.ReadLine();
            

            //string message = "";
            //if (userValue == "1")
            //    message = "You won a Mclaren P1!";
            //else if (userValue == "2")
            //    message = "You won a Porsche 918!";
            //else if (userValue == "3")
            //    message = "You won a LaFerrari!";
            //else
            //    message = "Sorry we did not usderstand! You lose!";
            //Console.WriteLine(message);

        string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0}", message);
            Console.ReadLine();

        }
    }
}
