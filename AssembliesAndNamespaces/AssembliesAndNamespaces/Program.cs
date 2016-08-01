//These are namespaces 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {


            string address = "https://www.facebook.com";
            WebClient client = new WebClient();
            string reply = client.DownloadString(address);
            File.WriteAllText(@"E:\Documents\GitHub\someText.txt", reply);
            Console.WriteLine(reply);
            Console.ReadLine();
        }
    }
}
