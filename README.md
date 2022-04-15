# Palindrome-Assessment

### Program.cs
Program.cs is the command line interface portion of the program. It contains a simple interface where the user can select a number of set options related to various functions in Palindrome.cs. The options include:
* Setting the paragraph property of the object.
* Printing the total number of palindrome words in the given paragraph
* Printing the total number of palindrome sentences in the given paragraph
* Printing each unique word alongside how many times it appears in the paragraph
* Printing a list of all the unique words in the paragraph that contain a given letter

When running the program from the command line, the user can include a paragraph of text in double quotes "" as an argument to set the initial paragraph in palindrome.cs, users who do not do this will be prompted to set one once the program begins. The program discards all arguments besides the first.

### Palindrome.cs
Palindrome.cs is the logic portion of the program. It contains 4 public function and one public property.

#### Public Properties
* Paragraph
    * this property manages getting and setting of a private property of the same name, while also updating several other private properties used by several of the class's methods.
    
#### Private Properties
* \_paragraph
    * the property hidden behind the public property Paragraph.
* \_words
    * a list containing each word in \_paragraph, in order, lowered and trimmed.
* \_sentences
    * a list containing each sentence in \_paragraph, in order, lowered and trimmed.
* \_wordDict
    * a dictionary<string,int> that contains each unique word that appears in \_paragraph, and how many times it appears.
    
#### Public Methods
* NumPalindromeWords()
    * counts the number of palindromes contained in \_words and prints a message containing that number to the command line.
* NumPalindromeSentences()
    * counts the number of palindromes contained in \_sentences and prints a message containing that number to the command line.
* ListWordCounts()
    * traverses \_wordDict, printing each word and how many times it appears in \_paragraph.
* GetWordsContainingLetter(char)
    * prints each word in \_wordDict that contains the given letter.
    
#### Private Methods
* bool IsPalindrome(string)
    * checks if the given string is a palindrome, after trimming whitespace and setting all characters to their lowercase form.