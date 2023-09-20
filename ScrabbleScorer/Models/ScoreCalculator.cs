using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;
using System;

namespace ScrabbleScorer.Models
{
  public class ScoreCalculator
  {
    public static Dictionary<char, int> letterValues = new Dictionary<char, int>
    {
      { 'A', 1 }, { 'E', 1 }, { 'I', 1 }, { 'O', 1 }, { 'U', 1 },
      { 'L', 1 }, { 'N', 1 }, { 'R', 1 }, { 'S', 1 }, { 'T', 1 },
      { 'D', 2 }, { 'G', 2 },
      { 'B', 3 }, { 'C', 3 }, { 'M', 3 }, { 'P', 3 },
      { 'F', 4 }, { 'H', 4 }, { 'V', 4 }, { 'W', 4 }, { 'Y', 4 },
      { 'K', 5 },
      { 'J', 8 }, { 'X', 8 },
      { 'Q', 10 }, { 'Z', 10 }
    };

    public static char[] WordToCharArray(string userInput)
    {
      char[] _word = userInput.ToUpper().ToCharArray();
      return _word;
    }

    public static int CalcScore(char[] wordArray)
    {
      int scoreKeeper = 0;
      for (int index = 0; index < wordArray.Length; index++)
      {
        for (int key = 0; key < letterValues.Count; key++)
        {
          KeyValuePair<char, int> v = letterValues.ElementAt(key);
          if (wordArray[index] == v.Key)
          {
            scoreKeeper += v.Value;
          }
        }
      }
      return scoreKeeper;
    }
  }
}

