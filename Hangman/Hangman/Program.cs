using System.Collections.Generic;
namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HangMan!\n");
            Console.WriteLine("A random word has been chosen...");
            Console.ReadLine();

            //Created a instance from the Random method, so that I can randomize the words.
            Random random = new Random();

            //List which holds the different words
            List<string> words = new List<string>();

            words.Add("horse");
            words.Add("computer");
            words.Add("iphone");

            //Variables for the selected word, as well as the length of the word
            string chosenWord = words[random.Next(words.Count)];
                //Console.WriteLine(chosenWord);
            int lengthOfWord = chosenWord.Length;

            //string __ = new string(char, int);
            string underscore = new string('_', lengthOfWord);

            Console.WriteLine($"The chosen word has: {underscore} words!");
            //Console.WriteLine(chosenWord + "" + lengthOfWord);

            //While loop to check if there is an underscore
            while (underscore.Contains('_'))
            { 
                List<char> lettersTried = new List<char>();

                Console.WriteLine("Enter a letter: ");
                char letter = Convert.ToChar(Console.ReadLine());

                for(int i = 0; i < lengthOfWord; i++)
                {
                    if (chosenWord[i] == letter)
                    {
                        underscore = underscore.Remove(i, 1).Insert(i, letter.ToString());
						Console.WriteLine($"Current word: {underscore}");
					}
                }

				if (!chosenWord.Contains(letter))
				{
					lettersTried.Add(letter);
					Console.WriteLine("Letter is not in the word! Try again\n");
				}
			}
            Console.WriteLine("You have completed the game");
		}
    }
}
