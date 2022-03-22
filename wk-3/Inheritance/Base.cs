namespace Inheritance
{
    public class Base
    {
        //Fields
        public string baseString;

        //constructor
        public Base()
        {
            this.baseString = "Base";
        }

        //Methods

        //Method Overriding is a method that lets us invoke the function/method of a
        //(base/super) class in another (derived/super)
        //Creating a method in the derived class with the same name as the base class.   

        //Access-Modifier Modifier Return-Type Method-Name(Parameters)
        public virtual void Speak() //The "Virtual"keywork is used to identify
        {
            Console.WriteLine("Hello, I am in a base type object.");
        }
    }
}