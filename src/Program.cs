using System;

namespace Code_Assessments
{
	class Program
	{
		static void Main(string[] args)
		{
			var pal = new Palindrome();
			if (args.Length == 0)
			{
				Console.WriteLine("No argument given for paragraph to analyse, please input a paragraph.");
				pal.Paragraph = Console.ReadLine();
				
			}
			else
			{
				pal.Paragraph = args[0];
			}
			int sel;
			bool cont = true;
			while(true)
			{
				sel = 0;
				Console.Clear();
				Console.WriteLine("---- Palindrome Analyzer ----");
				Console.WriteLine("1. Change paragraph to analyze.");
				Console.WriteLine("2. Print number of palindrome words in the paragraph.");
				Console.WriteLine("3. Print number of palindrome sentences in the paragraph.");
				Console.WriteLine("4. Print a list of unique words in the paragraph with a count of how many times it appears.");
				Console.WriteLine("5. Print a list of every word that contains a given letter in the paragraph.");
				Console.WriteLine("6. End program.");
				
				int.TryParse(Console.ReadLine(), out sel);
				
				switch(sel)
				{
					case 1:
						Console.WriteLine("Please enter the new paragraph: ");
						pal.Paragraph = Console.ReadLine();
						break;
					case 2:
						pal.NumPalindromeWords();
						break;
					case 3:
						pal.NumPalindromeSentences();
						break;
					case 4:
						pal.ListWordCounts();
						break;
					case 5:
						Console.WriteLine("Please enter the letter: ");
						pal.GetWordsContainingLetter(Console.ReadLine()[0]);
						break;
					case 6:
						cont = false;
						break;
					default: 
						Console.WriteLine("Invalid command, please try again.");
					break;

				}
				
				if(!cont)
				{
					break;
				}

				Console.ReadKey();
			}
		}
	}
}
