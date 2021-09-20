using System;
using System.Collections.Generic;
using Sphinx.Models;

namespace Sphinx
{
class Program
{
  public static bool askNextRiddle(int counter)
    {
      Console.WriteLine(Program.riddles[counter].GetQuestion());
      string guess = Console.ReadLine();
      if (guess.ToLower() == Program.riddles[counter].GetAnswer())
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


  public static List<Riddle> riddles = new List<Riddle>() {}; 
  public static void Main()
  {
    
    /*
    build a collection (list) of riddles

    display welcome message
    display the riddle - method
    collect input
    call the testing method
    display correct/false message
    */
    Riddle footsteps = new Riddle("The more you take, the more you leave behind. What am I?", "footsteps");
    Riddle penny = new Riddle("What has a head, a tail, is brown, and has no legs?", "penny");

    Program.riddles.Add(footsteps);
    Program.riddles.Add(penny);

    Console.WriteLine($"You have entered the lair of the sphinx. Answer its riddles correctly to survive.");

    for (int riddleIndex = 0; riddleIndex < Program.riddles.Count; riddleIndex++)
    {
      bool wasCorrect = Program.askNextRiddle(riddleIndex);
      if (wasCorrect)
      {
        if (riddleIndex == Program.riddles.Count - 1)
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
      // Console.WriteLine($"You win, ");
      
    }
    
    // 
    // Console.WriteLine(riddles[0].GetQuestion());
    // string guess = Console.ReadLine();
    // if (guess.ToLower() == riddles[0].GetAnswer())
    // {
    //   Console.WriteLine("Correct. " + riddles[1].GetQuestion());
    //   guess = Console.ReadLine();
    //   if (guess.ToLower() == riddles[1].GetAnswer())
    //   {
    //     Console.WriteLine("You win. Take the sphinx's treasure!");
    //   }
    //   else
    //   {
    //     Console.WriteLine("Your answer is incorrect. The sphinx will feast upon your bones.");
    //   }
    // }
    // else
    // {
    //   Console.WriteLine("Your answer is incorrect. The sphinx will feast upon your bones.");
    // }
    
    
  }
}
}