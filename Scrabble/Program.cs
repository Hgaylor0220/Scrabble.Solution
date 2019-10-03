using System;
using Game.Models;
using System.Text.RegularExpressions;
class Program
{

    static void Main()
    {
        Console.WriteLine("Enter a word and find out how many points this word is worth in Scrabble!");
        string input = Console.ReadLine();
        Regex regex = new Regex(@"[^a-zA-Z]+");
        Match result = regex.Match(input);

        Console.WriteLine("Your word score is: " + Scrabble.WordScore(input));
    }
}

