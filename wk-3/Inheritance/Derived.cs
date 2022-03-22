namespace Inheritance
{
    public class Derived : Base
    {
        //Fields
        public string derivedString;

        //Constructor
        public Derived()
        {
           this.derivedString = "Derived";

        }

        //Methods
        public override void Speak() //"Override" is required to extend or modifythe virtual method 
        {
            Console.WriteLine("I am a Derived type object.");
        }

        // All override members...
        // - Provide a new implementation of an inherited method
        // - Must have the same signature as the inherited method 
        // (signature is made of the return type, method name, and parameters)
        // - Both methods must be virtual and override
        // - Must NOT use static or virtal to override a method  

        public void Speak(string s)
        {
            Console.WriteLine("The Speak method was passed: " + s);
        }
    }
}