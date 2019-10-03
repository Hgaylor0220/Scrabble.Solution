using System.Collections.Generic;
using System;
using System.Linq;

namespace Game.Models
{
    public class Scrabble
    {   // set up dictionary to return the key with the value of the 'letter' (key,value)
        public static Dictionary<char,int> scrabble = new Dictionary<char,int>(){{'a',1},{'e',1},{'i',1},{'o',1},{'u',1},{'l',1},{'n',1},{'r',1},{'s',1},{'t',1},{'d',2},{'g',2},{'b',3},{'c',3},{'m',3},{'p',3},{'f',4},{'h',4},{'v',4},{'w',4},{'y',4},{'k',5},{'j',8},{'x',8},{'q',10},{'z',10}};
        // sets the values of the property of the class scrabble
        public static char[] Input { get; set;}
        static int Score = 0;
        // the method to calculate the value of the 'letter'
        public static int WordScore(string input)
        {
            Input = input.ToCharArray(); // turning the character from a string to an array of charaters. 
            for(int i =0; i< Input.Length; i++) // runs a for loop on the index for the input
                for(int j =0; j< scrabble.Count; j++) // runs a for loop on the index on the key element in the dictonary 
            {
                if(Input[i] == scrabble.ElementAt(j).Key) // match the index of the array to key of the dictionary.
                {
                    Score += scrabble.ElementAt(j).Value; // return the index value of the dictonary and adds it to the score.
                }
            }
            return Score; // returning new score
        }
        public static void ClearAll() // clears the score for the test to run with out a rolling total.
        {
            Score = 0;
        }
    }
}