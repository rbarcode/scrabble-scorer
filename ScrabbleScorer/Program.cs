
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
      ScoreCalculator.WordToCharArray(userInput);
      int result = ScoreCalculator.Score;

      Console.WriteLine($"The score of {userInput} is : {result}");


      Console.WriteLine("done!");

    }
  }

}