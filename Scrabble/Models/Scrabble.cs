using System.Collections.Generic;
using System;
using System.Linq;

namespace Game.Models
{
    public class Scrabble
    {

        public static Dictionary<char,int> scrabble = new Dictionary<char,int>(){{'a',1},{'e',1},{'i',1},{'o',1},{'u',1},{'l',1},{'n',1},{'r',1},{'s',1},{'t',1},{'d',2},{'g',2},{'b',3},{'c',3},{'m',3},{'p',3},{'f',4},{'h',4},{'v',4},{'w',4},{'y',4},{'k',5},{'j',8},{'x',8},{'q',10},{'z',10}};

        
        public static char[] Input { get; set;}
        static int Score = 0;

          
        public static int WordScore(string input)
        {
            Input = input.ToCharArray();
            for(int i =0; i< Input.Length; i++)
                for(int j =0; j< scrabble.Count; j++)
            {
                if(Input[i] == scrabble.ElementAt(j).Key)
                {
                    Score += scrabble.ElementAt(j).Value;
                }
            }
            return Score;
        }

        
    }
}