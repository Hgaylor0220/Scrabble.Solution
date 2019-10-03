using System;
using Game.Models;

class Program
{

    static void Main()
    {
        Console.WriteLine("Enter a word and find out how many points this word is worth in Scrabble!");
        string input = Console.ReadLine();
        // Scrabble scrabbleWord = new Scrabble();
        Console.WriteLine("Your word score is: " + Scrabble.WordScore(input));
    }
}

