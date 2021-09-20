using System;
using System.Collections.Generic;
using Sphinx.Models;

// /Users/nwdocadmin/Desktop/Epicodus/sphinx/Program.cs(11,7): error CS0118: 'Sphinx' is a namespace but is used like a type [/Users/nwdocadmin/Desktop/Epicodus/sphinx/Sphinx.csproj]

// /Users/nwdocadmin/Desktop/Epicodus/sphinx/Program.cs(11,29): error CS0118: 'Sphinx' is a namespace but is used like a type [/Users/nwdocadmin/Desktop/Epicodus/sphinx/Sphinx.csproj]

namespace Sphinx.Models
{
  public class SphinxData
  {
    private List<Riddle> _riddles;
    private int _riddleIndex;
    public SphinxData()
    {
      Riddle footsteps = new Riddle("The more you take, the more you leave behind. What am I?", "footsteps");
      Riddle penny = new Riddle("What has a head, a tail, is brown, and has no legs?", "penny");
      Riddle david = new Riddle("David's father has three sons: Snap, Crackle, and _____?", "david");
      Riddle piano = new Riddle("What has many keys, but can't even open a single door?", "piano");
      _riddles = new List<Riddle>() {footsteps, penny, david, piano};
      _riddleIndex = 0;
    }

    public string getNextQuestion()
    {
      return _riddles[_riddleIndex].Question;
    }

    public bool wasCorrect(string guess)
    {
      bool isCorrect = guess.ToLower() == _riddles[_riddleIndex].Answer;
      if (isCorrect) 
      {
        _riddleIndex++;
        return true;
      }
      else
      {
        return false;
      }
    }

    // get next question (string)
    // check if correct (bool) return true 
  }
}

      