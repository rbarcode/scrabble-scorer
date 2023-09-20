using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace ScrabbleScorer.Models
{
  public class ScoreCalculator
  {
    public static char[] WordToCharArray(string userInput)
    {
        char[] _word = userInput.ToCharArray();
        return _word; 
    }
  }
}