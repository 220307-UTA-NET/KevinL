using System;
using System.Collections.Generic;
using System.IO;

namespace FileInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = {"Hello", "Greetings", "Good Morning", "Good Afternoon"};

            //echo "text" >> .filename.txt
            //take this string "text", convert it to a stream of data
            // > or >> is a stream redirect, and we redirect to a targt file.

            string path = @".\Testfile.txt";

            //Test if the targetfileexists yet
            if ( ! File.Exists(path) ) //ifno
            {
                //Create and write to the file
                File.WriteAllLines(path, text);
            }

            else //if yes
            {
                //Open and append to the file
                File.AppendAllLines(path, text);
            }

            //Reading from target file to an array of strings called readText
            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }

            Person Anonymous = new Person("Anonymous", 68.5, 34);
            Console.WriteLine(Anonymous.name);
            Console.WriteLine("Anonymous is " + Anonymous.age + " years old.");
            Anonymous.GrowUp();
            Console.WriteLine("Anonymous is " + Anonymous.age + " years old.");

            Person MysteryGuy = new Person("Mystery Guy", 72.3);
            Console.WriteLine(MysteryGuy.name + " is " + MysteryGuy.age + " years old.");

            Console.WriteLine("Enter a new person: ");
            Person newPerson = new Person();
            Console.WriteLine(newPerson.name);
            Console.WriteLine(newPerson.height);
            Console.WriteLine(newPerson.age);
        }
    }
}
