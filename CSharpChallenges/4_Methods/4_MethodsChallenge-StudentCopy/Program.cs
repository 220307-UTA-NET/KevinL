using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            string name = GetName();
            GreetFriend(name);

            //2
            double result1 = GetNumber();
            double result2 = GetNumber();
            int action1 = GetAction();
            double result3 = DoAction(result1, result2, action1);

            System.Console.WriteLine($"The result of your mathematical operation is {result3}.");


        }

        public static string GetName()
        {
            Console.WriteLine("Hello,nice to meet you. What is your name?");
            string name = Console.Readline();
            return name;
            //throw new NotImplementedException();
        }

        public static void GreetFriend(string name)
        {

            Console.WriteLine("Hello, " + name + ". You are my friend.");
            //Greeting should be: Hello, nameVar. You are my friend
            //Ex: Hello, Jim. You are my friend
            //throw new NotImplementedException();
        }

        public static double GetNumber()
        {
            double result;
            bool repeat = true;
            do
            {
                Console.WriteLine("Enter your number");
                string input = Console.ReadLine();
                if(double.TryParse(input, out result))
                {
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please type the valid input!");
                }

            }while (repeat);
            return result;
            //Should throw FormatException if the user did not input a number
            //throw new NotImplementedException();
        }

        public static int GetAction()
        {
            int action;
            bool repeat;
            do
            {
                Console.WriteLine("Select the operator of math you want to perform.\n" + 
                "[1] Addition\n" + 
                "[2] Subtraction\n" + 
                "[3] Multiplication\n" + 
                "[4] Division\n");

                if (Int32.tryParse(Console.ReadLine(), out action))
                {
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input! Please type the valid input!");

                }
            }while(repeat);
            return action;
            //throw new NotImplementedException();
        }

        public static double DoAction(double x, double y, int z)
        {
            try
            {
                switch (action)
                {
                    case 1:
                    double addition = x + y;
                    return addition; 

                    case 2:
                    double subtraction = Math(x - y);
                    return subtraction;

                    case 3:
                    double multiplication = x * y;
                    return multiplication;

                    case 4:
                    double division = (x / y);
                    return division;

                    default:
                    throw new FormatException("typeof(System.FormatException)");
                }
            }

            catch ()
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            //throw new NotImplementedException();
        }
    }
}
