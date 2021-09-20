using System;
using System.Collections.Generic;
using Sphinx.Models;

namespace Sphinx
{
  class Program
  {
    public static void Main()
    {
      SphinxData mySphinx = new SphinxData();

      Console.WriteLine("You have entered the lair of the sphinx. Answer its riddles correctly to survive.");

      Console.WriteLine(mySphinx.getNextQuestion());
      string guess = Console.ReadLine();

      if (mySphinx.wasCorrect(guess))
      {
        Console.WriteLine("Correct!");
        //call it again somehow
        // Main();
      }
      else
      {
        Console.WriteLine("Your answer is incorrect. The sphinx will feast upon your bones.");
      }

      // for (int riddleIndex = 0; riddleIndex < riddles.Count; riddleIndex++)
      // {
      //   bool wasCorrect = Program.askNextRiddle(riddleIndex, riddles);
      //   if (wasCorrect)
      //   {
      //     if (riddleIndex == riddles.Count - 1)
      //     {
      //       Console.WriteLine("You win. Take the sphinx's treasure!");
      //     }
      //     else
      //     {
      //       Console.WriteLine("You must answer another riddle:");
      //     }
      //   }
      //   else
      //   {
      //     break;
      //   }
      // }

    }
  }
}