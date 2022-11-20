//1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
using System;
static void Main(string[] args)
{
    Console.WriteLine("Please enter a list of numbers, separated by a hyphen.");
    var inputStr = Console.ReadLine();

    Console.WriteLine(IsConsecutive(inputStr));

}
static string IsConsecutive(string input)
{
    var inputArr = input.Split("-");

    for (var i = 1; i < inputArr.Length; i++)
    {
        if (Convert.ToInt32(inputArr[i]) < Convert.ToInt32(inputArr[i - 1]))
            return "Not Consecutive!";
    }

    return "Consecutive!";
}


//2- Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
static void Main(string[] args)
{
	Console.WriteLine("Enter numbers separated by a hyphen, and I'll tell you if there are duplicates. (Enter to exit)");

	var numInput = Console.ReadLine();

	if (numInput != null)
		Console.WriteLine(AreThereDupes(numInput));
	else
		return;
}
static string AreThereDupes(string numInput)
{
	var inputArr = numInput.Split('-');
	var uniqueArr = inputArr.Distinct().ToArray();
	if (inputArr.Length != uniqueArr.Length)
		return "Duplicates";
	else
		return "No duplicates!";
}


//3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
static void Main(string[] args)
{
	Console.WriteLine("Please enter a time in the format hh:mm");
	var inputStr = Console.ReadLine();
	if (inputStr == null)
		Console.WriteLine("Invalid Time");
	else
	{
		var inputArr = inputStr.Split(":");
		if (Convert.ToInt32(inputArr[0]) > 23 || Convert.ToInt32(inputArr[1]) > 59)
			Console.WriteLine("Invalid Time");
		else
			Console.WriteLine("Ok");
	}
}


//4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
static void Main(string[] args)
{
	Console.WriteLine("Enter a few words separates by a space to PascalCase them!");
	var inputStr = Console.ReadLine()?.ToLower();
	var inputArr = inputStr?.Split(" ");
	var strBuild = new StringBuilder();

	foreach (var word in inputArr)
		strBuild.Append((word[0].ToString().ToUpper() + word.Substring(1)));

	Console.WriteLine(strBuild);
}


//5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.
static void Main(string[] args)
{
	Console.WriteLine("Enter a word and I'll count the vowels!");
	var inputStr = Console.ReadLine();
	var inputArr = inputStr.ToCharArray();
	var vowelCount = 0;

	foreach (var letter in inputArr)
		if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
			vowelCount++;

	Console.WriteLine(vowelCount);
}