using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
            */
            string zig = "This is an string";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char letter in charArray)
            {
                Console.Write(letter);
            }
            Console.ReadLine();
        }
    }
}
