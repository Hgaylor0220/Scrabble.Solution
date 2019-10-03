using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;

namespace Game.Test
{
    [TestClass]
    public class ScrabbleTest
    {
        
        [TestMethod]
        public void Scrabble_CanUserEnterAWord_A()
        {
            //Arrange
            string input = "a";
            //Act
            int result = Scrabble.WordScore(input);
            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
