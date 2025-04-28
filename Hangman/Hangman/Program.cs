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

            words.Add("Horse");
            words.Add("Computer");
            words.Add("Iphone");

            //Variables for the selected word, as well as the length of the word
            string chosenWord = words[random.Next(words.Count)];
            int lengthOfWord = chosenWord.Length;

            //string __ = new string(char, int);
            string underscore = new string('_', lengthOfWord);

            Console.WriteLine($"The chosen word has: {underscore} words!");
            //Console.WriteLine(chosenWord + "" + lengthOfWord);

            //While loop;
        }
    }
}
