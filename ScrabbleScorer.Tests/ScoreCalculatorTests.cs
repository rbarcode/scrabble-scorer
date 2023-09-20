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
      char[] testArray = { 'A', 'P', 'P', 'L', 'E' };
      // Assert
      CollectionAssert.AreEqual(testArray, output);
    }

    [TestMethod]
    public void CalcScore_CalcScoreFromWordArray_Int()
    {
      char[] wordArray = { 'A', 'P', 'P', 'L', 'E' };
      int pointsResult = ScoreCalculator.CalcScore(wordArray);
      Assert.AreEqual(9, pointsResult);
    }

    [TestMethod]
    public void CalcScore_CalcScoreFromWordArray2_Int()
    {
      char[] wordArray = { 'Z', 'E', 'B', 'R', 'A' };
      int pointsResult = ScoreCalculator.CalcScore(wordArray);
      Assert.AreEqual(16, pointsResult);
    }
  }
}
