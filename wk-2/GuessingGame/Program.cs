//Guessing game - Play a quick guessing game with the computer. 
Console.WriteLine("Welcome to Kevin's Number Guessing Game");

while( true ) //Being the Loop!
{

	Console.WriteLine("Enter the number for the menu option of your choice: ");
	Console.WriteLine("[1] - Play the guessing game");
	Console.WriteLine("[0] - Exit");

	int menu = int.Parse(Console.ReadLine());

	switch( menu )
	{ 

	case 0:
		return;

	case 1:

		var rand = new Random(); //Creates the random number
		int secret  = rand.Next(1, 21); //Limit the random number 1 - 20, then save as int to "secret"

		while ( true ) //Begin the loop!
		{

			Console.WriteLine("Guess a number between 1 and 20: "); //Prompt the user
			int input = int.Parse(Console.ReadLine()); //Read user input, parsing to an int, then save as int "input"
			Console.WriteLine("You guessed: " + input); //Confirming the input with the user

			if (input == secret) //In the user guessed the secret number (if input is equal to secret number)
			{
				Console.WwriteLine("Congratulations! you've correctly guessed the secret number!");
				break; //Break out of the while loop!
			}

			else if (input > secret) //If the user guessed too high (If the input is greater than the secret number)
			{
			Console.WriteLine("Uh oh, you guessed the number too high!");
			}	

			else //If the user guessed too low (If the input is lower than the secret number)
			{		
			Console.WriteLine("Oops, you guessed the number too low!");
			}
		}
	
		Console.Writeline("Good game, thanks for playing!");
		break;

		default:
			Console.WriteLine("Bad Input: Input wasnot a valid option.");
			break;
	}
}

 
