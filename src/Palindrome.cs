using System;
using System.Collections.Generic;
using System.Linq;

namespace Code_Assessments
{
	class Palindrome
	{
		private string _paragraph;
		public string Paragraph
		{
			get
			{
				return _paragraph;
			}
			set
			{
				_paragraph = value;
				
				char[] separators = new char[] { ' ', '.', '?', '!', '\'' };
				_words = value.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
				for(int i = 0; i<_words.Count; i++)
				{
					_words[i] = _words[i].Trim();
				}

				separators = new char[] { '.', '?', '!' };
				_sentences = value.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
				for(int i = 0; i < _sentences.Count; i++)
				{
					_sentences[i] = _sentences[i].Replace(" ", "").Replace(",", "").Replace("\'", "").Trim();
				}
				
				_wordDict = new Dictionary<string, int>();
				_words.ForEach(word =>
				{
					if (_wordDict.Keys.Contains(word))
						_wordDict[word]++;
					else
						_wordDict.Add(word, 1);
				});
			}
		}
		private List<string> _words;
		private List<string> _sentences;
		private Dictionary<string, int> _wordDict;

		private bool IsPalindrome(string word)
		{
			word = word.Trim().ToLower();
			for (int i = 0; i < word.Length / 2; i++)
			{
				if (word.Substring(i, 1) != word.Substring(word.Length - i - 1, 1))
					return false;
			}
			return true;
		}

		// Give the number of palindrome words
		public void NumPalindromeWords()
		{
			int palindromeWordsCount = 0;
			_words.ForEach(word =>
			{
				if (IsPalindrome(word))
					palindromeWordsCount++;
			});
			Console.WriteLine($"There are {palindromeWordsCount} palindrome words in the paragraph.");
		}

		// Give the number of palindrome sentences
		public void NumPalindromeSentences()
		{
			int palindromeSentencesCount = 0;
			_sentences.ForEach(sentence =>
			{
				if (IsPalindrome(sentence))
					palindromeSentencesCount++;
			});
			Console.WriteLine($"There are {palindromeSentencesCount} palindrome sentences in the paragraph.");
		}

		public void ListWordCounts()
		{
			foreach (var key in _wordDict.Keys)
			{
				Console.WriteLine($"{key} - {_wordDict[key]}");
			}
		}
		
		// Let the user also input a letter at some point and list all words containing that letter 
		public void GetWordsContainingLetter(char letter)
		{	
			Console.WriteLine($"Words containing the letter {letter} in the paragraph:");
			foreach (var word in _wordDict.Keys)
			{
				if (word.Contains(letter))
				{
					Console.WriteLine(word);
				}
			}
		}
	}
}