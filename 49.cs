// 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
static void Main(string[] args)
{
	var divBy3Count = 0;

	for (var i = 1; i <= 100; i++)
	{
		if (i % 3 == 0) divBy3Count++;
	}

	Console.WriteLine(divBy3Count);
}


// 2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
static void Main(string[] args)
{
	var sum = 0;

	while (true)
	{
		Console.WriteLine("Enter a number to add it to the sum, or \"ok\" to exit!");
		var response = Console.ReadLine();

		if (response != "ok")
		{
			sum += int.Parse(response);
			continue;
		}

		break;
	}

	Console.WriteLine(sum);
}


// 3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
static void Main(string[] args)
{
	Console.WriteLine("Enter a number and I'll tell you its factorial!");
	var num = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(Factorial(num));
}

static int Factorial(int num)
{
	var result = num;

	for (var i = 1; i < num; i++)
	{
		result *= i;
	}

	return result;
}


// 4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
static void Main(string[] args)
{
	var rand = new Random();
	var secretNumber = rand.Next(1, 10);
	var attempts = 0;

	Console.WriteLine("Guess the number between 1 and 10!");
	
	for (var i = 0; i < 4; i++)
	{ 
		Console.WriteLine("...{0} guesses remaining...", 4-i);
		var userResponse = int.Parse(Console.ReadLine());

		if (userResponse == secretNumber)
		{
			Console.WriteLine("You win!");
			break;
		} else
		{
			attempts++;

			if (attempts != 4)
			{
				Console.WriteLine("Wrong! Guess again:");
				continue;
			} else
			{
				Console.WriteLine("You lose! The number was {0}.", secretNumber);
				break;
			}
		}
	}
}


// 5- Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
static void Main(string[] args)
{
	Console.WriteLine("Enter a series of numbers, separated by a comma");

	var response = Console.ReadLine();
	string[] nums = response.Split(", ");
	var max = int.MinValue;

	foreach (var num in nums)
	{
		if (Convert.ToInt32(num) > max)
		{
			max = Convert.ToInt32(num);
		}
	}

	Console.WriteLine("The maximum value is {0}", max);
}