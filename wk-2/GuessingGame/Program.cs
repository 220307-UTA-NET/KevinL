//Guessing game - Play a quick guessing game with the computer. 
namespace GuessingGame
{
	class Program
	{
		static void Main(string[] args)
		{
				Console.WriteLine("Welcome to Kevin's Number Guessing Game");
				var rand = new Random();

				while( true ) //Being the Loop!
				{

					/*string? one;
					string? two;

					one = Console.ReadLine();
					two = Console.ReadLine();

					Console.WriteLine(one);
					Console.WriteLine(two);*/
					

					Console.WriteLine("Enter the number for the menu option of your choice: ");
					Console.WriteLine("[1] - Play the guessing game");
					Console.WriteLine("[2] - Math Challenge!");
					Console.WriteLine("[0] - Exit");

					int menu = int.Parse(Console.ReadLine());

					switch( menu )
					{ 
						case 0:
							Console.WriteLine("Press any key to continue");
							Console.ReadLine();
							Console.Clear();
							break;
						case 1:
							GuessingGame();
							break;
						case 2:
							AdditionChallenge();
							break;
						default:
							Console.WriteLine("Bad Input: Input was not a valid option.");
							break;
					}
				}
		}
		static void GuessingGame()
		{
			var rand = new Random(); //Creates the random number
			int secret  = rand.Next(1, 21); //Limit the random number 1 - 20, then save as int to "secret"

			while ( true ) //Begin the loop!
			{

				Console.WriteLine("Guess a number between 1 and 20: "); //Prompt the user

				int? input;
				string? in2 = Console.ReadLine();			

				try
				{
					input = int.Parse(in2); //Read user input, parsing to an int, then save as int "input"
				}
				catch (System.Exception ex)
				{
					Console.WriteLine(ex.Message); 
					//Console.WriteLine("Bad input detected. Returning to menu.");
					break;
				}
				
				Console.WriteLine("You guessed: " + input); //Confirming the input with the user

				if (input == secret) //In the user guessed the secret number (if input is equal to secret number)
				{
					Console.WriteLine("Congratulations! you've correctly guessed the secret number!");
					break; //Break out of the while loop!
				}

				else if (input > secret) //If the user guessed too high (If the input is greater than the secret number)
				{
					Console.WriteLine("Uh oh, you guessed the number too high!");
					Console.WriteLine("Press any key to continue");
					Console.ReadLine();
					Console.Clear();
				}	

				else //If the user guessed too low (If the input is lower than the secret number)
				{		
					Console.WriteLine("Oops, you guessed the number too low!");
					Console.WriteLine("Press any key to continue");
					Console.ReadLine();
					Console.Clear();
				}
			}

			Console.WriteLine("Good game, thanks for playing!");		
		}
		static void AdditionChallenge()
		{
			var rand = new Random(); //Generating the random value for the problem 
			int num1 = rand.Next(1, 20);
			int num2 = rand.Next(1, 20);

			int sol = num1 + num2; //Finding the correct solution
			Console.WriteLine("Welcome to the Addition challenge!");

			while(true)
			{
				Console.WriteLine("Your question is: ");
				Console.WriteLine("The first random number is : " + num1 + " + The second random number is: " + num2);

				Console.WriteLine("Please enter your solution: ");
				string userGuess = Console.ReadLine(); // Accepting the users solution

				int intUserGuess;

				bool success = int.TryParse(userGuess, out intUserGuess);

				if (success)
				{
					intUserGuess = int.Parse(userGuess);
				}
				else
				{
					Console.WriteLine("Invalid input. Exiting Additional Challenge.");
					break;
				}

				if ( sol == intUserGuess )
				{
					Console.WriteLine("Bull's eye! you guesses the correct the number!");
					Console.WriteLine("Press any key to continue");
					Console.ReadLine();
					Console.Clear();
					break;		
				}
				else
				{
					Console.WriteLine("Wrong guess, you were off by: " + Math.Abs( sol - intUserGuess ));
					Console.WriteLine("Press any key to continue");
					Console.ReadLine();
					Console.Clear();
					break;
				}
			}
		}
	}
}