using System;
using System.Collections.Generic;

namespace Sphinx.Models
{
public class Riddle
{
  // public static Dictionary<string, string> riddles = new Dictionary<string, string>() { {"The more you take, the more you leave behind. What am I?", "Footsteps"}, {"What has a head, a tail, is brown, and has no legs?", "A Penny"} };
  private string _question;
  private string _answer;

  public Riddle(string question, string answer)
  {
    _question = question;
    _answer = answer;
  }

  public string GetQuestion()
  {
    return _question;
  }
  public string GetAnswer()
  {
    return _answer;
  }
}
}