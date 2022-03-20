using System;
using System.Collections.Generic;
using System.IO;

namespace ClassesOOP
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Does this template work?");
            Square squareOne = new Square();

            Console.WriteLine(squareOne.numberOfSides);
            Console.WriteLine(squareOne.getPerimiter());
            //Console.WriteLine(squareOne.sideLength.get);
        }
    }
}