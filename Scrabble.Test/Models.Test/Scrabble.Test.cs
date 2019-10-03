using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;
using System;

namespace Game.Test
{
    [TestClass]
    public class ScrabbleTest : IDisposable
   {    
       public void Dispose()
        {
            Scrabble.ClearAll();
        }

        [TestMethod]
        public void WordScore_CanUserEnterALetter_A()
        {
            //Arrange
            string input = "a";
            //Act
            int result = Scrabble.WordScore(input);
            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void WordScore_CanUserEnterAWord_Hello()
        {
            string input = "hi";
            int result = Scrabble.WordScore(input);
            Assert.AreEqual(5, result);
        }
    }
}
