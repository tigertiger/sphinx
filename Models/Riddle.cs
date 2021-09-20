using System;
using System.Collections.Generic;

namespace Sphinx.Models
{
public class Riddle
{
  public string Question { get; }
  public string Answer { get; }

  public Riddle(string question, string answer)
  {
    Question = question;
    Answer = answer;
  }

}
}
