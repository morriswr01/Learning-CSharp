using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter length 1: ");
            int len1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter length 2: ");
            int len2 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the angle: ");
            int angle = int.Parse(Console.ReadLine());
            bool equal = false;
            bool isNinety = false;
            bool choosenAngles = false;

            if (len1 == len2)
                equal = true;
            if (angle == 90)
                isNinety = true;
            if (angle == 60 || angle == 120)
                choosenAngles = true;
            Console.WriteLine("Is ninety :" + isNinety);
            Console.WriteLine("Equal is: " + equal);
            Console.WriteLine("choosenAngles is: " + choosenAngles);
            Console.ReadLine();

            Console.Write(WhatShape(equal, isNinety, choosenAngles));
            Console.ReadLine();

        }

        private static string WhatShape(bool equal, bool isNinety, bool choosenAngles)
        {


            if (isNinety && equal)
            {
                return "This is a Square crystal!";
            }
            else if (isNinety && !(equal))
            {
                return "This is a Rectangular crystal!";
            }
            else if (choosenAngles)
            {
                return "This is a Hexagonal crystal!";
            }
            else if (!(isNinety) && !(choosenAngles) && equal)
            {
                return "This is a Rhombic crystal!";
            }
            else if (!(choosenAngles) && !(equal))
            {
                return "This is a Parralellogram crystal!";
            }
            return "This is not a known shape";
        }
    }

}
