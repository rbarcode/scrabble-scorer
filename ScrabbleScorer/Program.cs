
using System;
using ScrabbleScorer.Models;

namespace ScrabbleScorer
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter a word to check it's score using ScrabbleScorer");
      string userInput = Console.ReadLine();
      char[] wordArray = ScoreCalculator.WordToCharArray(userInput);
      int result = ScoreCalculator.CalcScore(wordArray);

      Console.WriteLine($"The score of {userInput} is : {result}");

      Console.WriteLine("done!");


    }
  }

}