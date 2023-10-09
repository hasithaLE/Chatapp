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
		string lowercaseMsg = msg.ToLower();

		if (lowercaseMsg == "hi")
		{
			Console.WriteLine("Hey, Welcome");
			userInput();
		}
		else if (lowercaseMsg == "buy")
		{
			Console.WriteLine("Welcome to shop");
			userInput();
		}
		else if (lowercaseMsg == "bye")
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