// 1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
// If no one likes your post, it doesn't display anything.
// If only one person likes your post, it displays: [Friend's Name] likes your post.
// If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
// If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
// Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
static void Main(string[] args)
{
	var friends = new List<string>();

	Console.WriteLine("Enter a name. When you're done, press ENTER");

	while (true)
	{
		var name = Console.ReadLine();

		if (!String.IsNullOrEmpty(name))
			friends.Add(name);
		else
			break;
	}

	if (friends.Count == 1)
		Console.WriteLine("{0} likes your post.", friends[0]);
	else if (friends.Count == 2)
		Console.WriteLine("{0} and {1} like your post.", friends[0], friends[1]);
	else if (friends.Count >= 3)
		Console.WriteLine("{0}, {1}, and {2} others like your post.", friends[0], friends[1], friends.Count - 2);
}


// 2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
static void Main(string[] args)
{
	Console.WriteLine("Please enter your name to be reversed:");
	var name = Console.ReadLine();
	var charArr = name.ToCharArray();
	Array.Reverse(charArr);
	Console.WriteLine(new string(charArr));
}


// 3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
static void Main(string[] args)
{
	var numList = new List<int>();
	Console.WriteLine("Please enter 5 unique numbers to be sorted!");

	while (numList.Count < 5)
	{
		var numInput = Convert.ToInt32(Console.ReadLine());

		if (numList.IndexOf(numInput) == -1)
			numList.Add(numInput);
		else
			Console.WriteLine("You've already entered that number, try again.");
	}

	numList.Sort();

	foreach (var num in numList)
		Console.Write(num + " ");
}


// 4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.
static void Main(string[] args)
{
	var numList = new List<int>();

	Console.WriteLine("Type a number! Or \"Quit\" to exit.");

	while (true)
	{
		var input = Console.ReadLine().ToLower();

		if (input != "quit")
			numList.Add(Convert.ToInt32(input));
		else
			break;
	}

	var uniqueNumList = numList.Distinct().ToList();

	foreach (var num in uniqueNumList)
		Console.WriteLine(num);
}


// 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
static void Main(string[] args)
{
	Console.WriteLine("Please supply a list of at least 5 comma separated numbers (e.g 5, 1, 9, 2, 10)");

	while (true)
	{
		var userInput = Console.ReadLine();
		var numArray = userInput.Split(", ");
		var numList = new List<int>();

		if (numArray.Length < 5)
		{
			Console.WriteLine("Invalid List, please try again");
			continue;
		} else {
			foreach (var num in numArray)
			{
				numList.Add(Convert.ToInt32(num));
			}

			numList.Sort();
			Console.WriteLine("{0} {1} {2}", numList[0], numList[1], numList[2]);
			break;
		}
	}
}