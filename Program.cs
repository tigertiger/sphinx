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
      void displayQuestion ()
      {
        Console.WriteLine(mySphinx.getNextQuestion());
        string guess = Console.ReadLine();

        if (mySphinx.wasCorrect(guess))
        {
          Console.WriteLine("Correct!");
          //test if it's the last one - "base case"
          if (mySphinx.getNextQuestion() == "you win")
          {
            Console.WriteLine("You win. Take the sphinx's treasure!");
          }
          else
          {
            Console.WriteLine("You must answer another riddle:");
            displayQuestion();
          }
        }
        else
        {
          Console.WriteLine("Your answer is incorrect. The sphinx will feast upon your bones.");
        }
      }

      Console.WriteLine("You have entered the lair of the sphinx. Answer its riddles correctly to survive.");

      displayQuestion();
    }

    
  }
}