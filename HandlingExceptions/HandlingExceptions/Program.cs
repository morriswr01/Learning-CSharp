using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string content = File.ReadAllText(@"E:\Documents\GitHub\someTex.txt");
                Console.WriteLine(content);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error wront thing");
            };

            Console.ReadLine();
        }
    }
}
