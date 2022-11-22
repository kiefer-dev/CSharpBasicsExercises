//1- Write a program that reads a text file and displays the number of words.
static void Main(string[] args)
{
	var text = File.ReadAllText(@"C:\Users\kiefe\Desktop\KNOWLEDGE\C#\Beginner Course\ConsoleApp1\example.txt");
	var wordArray = text.Split(new char[] {' ', '\n'});

	Console.WriteLine(wordArray.Length);
}
static void DisplayWords(string[] words)
{
	for (var i = 0; i < words.Length; i++)
		Console.WriteLine("{0} {1}", i + 1, words[i]);
}


//2- Write a program that reads a text file and displays the longest word in the file.
static void Main(string[] args)
{
	var text = File.ReadAllText(@"C:\Users\kiefe\Desktop\KNOWLEDGE\C#\Beginner Course\ConsoleApp1\example.txt");
	var wordArray = text.Split(new char[] {' ', '\n'});

	Console.WriteLine(FindLongestWord(wordArray));
}
static string FindLongestWord(string[] words)
{
	var longest = new StringBuilder("a");

	foreach (var word in words)
		if (word.Length > longest.Length)
		{
			longest.Clear();
			longest.Append(word);
		}

	return longest.ToString();
}