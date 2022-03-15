// See https://aka.ms/new-console-template for more information
string string1;
int var1;

Console.WriteLine("Please enter your message and press enter");
string1 = Console.ReadLine();

Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");
var1 = int.Parse(Console.ReadLine());

char var2;

Console.WriteLine("For which character should I search in your original message?");
var2 = char.Parse(Console.ReadLine());

Console.WriteLine("Please type your first name.");
string firstName = Console.ReadLine();
Console.WriteLine("Please type your last name.");
string lastName = Console.ReadLine();

Console.WriteLine("First Name: " + firstName + "\nLast Name: " + lastName);
Console.WriteLine("The initials of the user's first name and last name are: " + firstName.Substring(0,1) + "." + lastName.Substring(0,1)+".");
Console.WriteLine("The initials of the user's first name and first two letters of the name are: "+ firstName+ " and " + lastName.Substring(0,2));
Console.WriteLine(lastName.Length);



