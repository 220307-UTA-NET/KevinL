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

            Console.WriteLine("Square numberof sides: " + squareOne.numberOfSides);
            Console.WriteLine("Square perimiter: " + squareOne.getPerimiter());
           

           try
           {
            Triangle newTriangle = new Triangle(10, 10, 2);
            Console.WriteLine("Perimiter of the triangle = " + newTriangle.Perimiter());
           }
           catch (Exception e)
           {
               Console.WriteLine("Triangle was not able to be created, invalid sides.");
           }
           
           Console.WriteLine("The program continues after the Try-Catch");
        }
    }
}