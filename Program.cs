using System;
using System.Collections.Generic;
using Sphinx.Models;

namespace Sphinx
{
  class Program
  {
    public static bool askNextRiddle(int counter, List<Riddle> riddles)
    {
      Console.WriteLine(riddles[counter].Question);
      string guess = Console.ReadLine();
      if (guess.ToLower() == riddles[counter].Answer)
      {
        Console.WriteLine("Correct!");
        return true;
      }
      else
      {
        Console.WriteLine("Your answer is incorrect. The sphinx will feast upon your bones.");
        return false;
      }
    }


    public static void Main()
    {
      List<Riddle> riddles = new List<Riddle>() {};
      Riddle footsteps = new Riddle("The more you take, the more you leave behind. What am I?", "footsteps");
      Riddle penny = new Riddle("What has a head, a tail, is brown, and has no legs?", "penny");
      Riddle david = new Riddle("David's father has three sons: Snap, Crackle, and _____?", "david");
      Riddle piano = new Riddle("What has many keys, but can't even open a single door?", "piano");

      riddles.Add(footsteps);
      riddles.Add(penny);
      riddles.Add(david);
      riddles.Add(piano);

      Console.WriteLine($"You have entered the lair of the sphinx. Answer its riddles correctly to survive.");

      for (int riddleIndex = 0; riddleIndex < riddles.Count; riddleIndex++)
      {
        bool wasCorrect = Program.askNextRiddle(riddleIndex, riddles);
        if (wasCorrect)
        {
          if (riddleIndex == riddles.Count - 1)
          {
            Console.WriteLine("You win. Take the sphinx's treasure!");
          }
          else
          {
            Console.WriteLine($"You must answer another riddle:");
          }
        }
        else
        {
          break;
        }
      }

    }
  }
}