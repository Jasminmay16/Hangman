using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanMiniProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to HangMan!");
			Console.WriteLine("A random word has been chosen...");

			Random random = new Random();

			List<string> words = new List<string>();

			words.Add("Horse");
			words.Add("Computer");
			words.Add("Iphone");

			int chosenWord = random.Next(words.Count);

			Console.WriteLine(words[chosenWord]);
		}
	}
}
