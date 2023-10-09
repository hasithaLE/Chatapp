using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("ChatBot 1.0");
		userInput();
	}

	static void userInput()
	{
		Console.WriteLine("Hi - to Customer Support \nBuy - to show products \nBye - to End Chat\n");
		Console.Write("You >> ");
		string msg = Console.ReadLine();

		if (msg == "Hi") 
		{
			Console.WriteLine("Hey, Welcome");
			userInput();
		}
		else if (msg == "Buy")
		{
			Console.WriteLine("Welcome to shop");
			userInput();
		}
		else if (msg == "Bye")
		{
			Console.WriteLine("See you...");
		}
		else
		{
			Console.WriteLine("Invalid Input");
			userInput();
		}
		//Console.WriteLine("Your message is : " + msg);
	}
}