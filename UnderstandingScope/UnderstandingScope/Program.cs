using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {

            //Private mean aa method can be called by any other method in the same class
            //Public is for the block thats going to be called outside of the class, it is global
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Out of scope
                //Console.WriteLine(l);
            }
            // "i" is now outside of the scope of the for loop
            //Console.WriteLine(i);
            // J defined outside of code block, so is accessable, it is global
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for: " + k);
            HelperMethod();
            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod(): " + k);  
        }


    }
}
