using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScorer.Models;
using System;

namespace ScrabbleScorer.Tests
{

  [TestClass]
  public class ScoreCalculatorTests
  {
    [TestMethod]
    public void WordToCharArray_CreatesArrayOfCharFromWord_Array()
    {
      // Arrange
      string userInput = "apple";
      // Act
      char[] output = ScoreCalculator.WordToCharArray(userInput);
      char[] testArray = { 'a', 'p', 'p', 'l', 'e' };
      // Assert
      CollectionAssert.AreEqual(testArray, output);
    }
  }
}
