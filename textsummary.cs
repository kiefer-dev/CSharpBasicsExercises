static void Main(string[] args)
        {
            Console.WriteLine(SummerizeText("Hello, my name is Kiefer! How are you doing today?", 10));

        }

static string SummerizeText(string sentence, int maxLength = 20)
    {
		if (sentence.Length < maxLength)
			return sentence;
		else
		{
			var words = sentence.Split(' ');
			var totalCharacters = 0;
			var summaryWords = new List<string>();

			foreach (var word in words)
			{
				summaryWords.Add(word);

				totalCharacters += word.Length + 1;
				if (totalCharacters > maxLength)
					break;
			}

			return String.Join(" ", summaryWords) + "...";
		}
	}