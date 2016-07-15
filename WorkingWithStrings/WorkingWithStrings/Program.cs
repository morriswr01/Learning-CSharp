using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if i need a new \nline?";
            //string myString = "Go to your c:\\ drive";
            //string myString = String.Format("{1} = {0}", "First", "Second");

            //:C means currency
            //string myString = String.Format("0:C", 123.45);

            //Add in commas for larg numbers
            //string myString = string.Format("{0:N}",123456789);

            //Perecentage
            //string myString = string.Format("Percentage: {0:P}", .123);

            //Formats for a phone number (for a us number)
            //string myString = string.Format("Phone number: {0:(###) ###-####}", 1234567809);

            //Takes all chars after the give number in the parentheses. The 14 is the number of chars after the first 6 that are displayed
            //string myString = string.Format(" That summer we took threes accross the board ");
            //myString = myString.Substring(6, 14);
            //Upper case
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);

            //myString = string.Format("Length before: {0} -- Length After {1}", myString.Length, myString.Trim().Length);

            //Inefficient for memory management
            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();

            }
            */

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i.ToString());
            }




            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
