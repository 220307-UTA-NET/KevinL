using System;
using System.Collections.Generic;
using System.IO;

namespace ClassesOOP
{
    class Square
    {
        public int numberOfSides;
        double perimiter;
        double sideLength; //{get; set;} "Shorthand" way to write simple getter and setter methods for a field.
        double area;

        public Square()
        {
            this.numberOfSides = 4;
            this.sideLength = 1.0;            
            setCalcPerimiter(this.numberOfSides, this.sideLength);
            this.area = calcArea(this.sideLength);

        }

        void setCalcPerimiter(int Sides, double Length)
        {
            this.perimiter = (Sides * Length);
        }

        double calcArea(double length)
        {
            return (length * length);
        }     

        //Getter - is a method that returns the value ofprivate (or otherwise) member
        public double getPerimiter()
        {
            return this.perimiter;
        }      

        //Setter - is a method sets the value of a private (or otherwise) member
        public void setPerimiter (double Perimiter)
        {
            this.perimiter = Perimiter;
        } 


    }
}