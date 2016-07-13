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
            int x = int.Parse(Console.ReadLine());
            Console.Write("Please enter length 2: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Please enter the angle: ");
            int angle = int.Parse(Console.ReadLine());
            bool equal = false;
            bool choosenAngles = false;
            bool isNinety = false;
            if (x == y)
                equal = true;
            else if (angle == 60 || angle == 120)
                choosenAngles = true;
            else if (angle == 90)
                isNinety = true;

            Console.WriteLine(WhatShape(equal, choosenAngles, isNinety));
            Console.ReadLine();

        }

        private static string WhatShape(bool equal, bool choosenAngles, bool isNinety)
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
            //else if (!(isNinety) && !(choosenAngles) && equal)
            //{
            //    return "This is a Rhombic crystal!";
            //}
            else if (!(choosenAngles) && !(equal))
            {
                return "This is a Parralellogram crystal!";
            }
            return "This is not a known shape";
        }
    }

}
