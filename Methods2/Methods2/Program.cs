using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The name game:");
            Console.Write("What is your first name?");
            string firstName = Console.ReadLine();
            Console.Write("What is your last name?");
            string lastName = Console.ReadLine();
            Console.Write("Where were you born?");
            string whereBorn = Console.ReadLine();

            Console.Write("Result: "+ reverseArray(firstName) + " " + reverseArray(lastName) + " " + reverseArray(whereBorn));
            Console.ReadLine();
            
        }
        //No method should have more than six lines of code. Possibly needs splitting up.
        private static string reverseArray(string inpString)
        {
            char[] messageArray =  inpString.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);           
        }

    }
}
