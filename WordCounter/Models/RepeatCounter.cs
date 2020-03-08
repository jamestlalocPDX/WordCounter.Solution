using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string Word {get; set; }
    public string Sentence { get; set; }
    public int Count { get; set; }
    
    public RepeatCounter(string word)
    {
      Word = word;
    }

    public RepeatCounter(string word, string sentence)
    : this(word)
    {
      Sentence = sentence;
      Count = 0;
    }    
  }
}