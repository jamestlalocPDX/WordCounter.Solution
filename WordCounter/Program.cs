using System;
using WordCounter.Models;

namespace WordCounter
{
  public class program
  {
    public static void Main()
    {
      Console.WriteLine("Hello, world! Welcome to The Word Counter Extraordinaire.");
      Console.WriteLine("Please enter a word.");
      string userWord = Console.ReadLine().ToLower();

      Console.WriteLine("Great! Now please enter a sentence.");
      string userSentence = Console.ReadLine().ToLower();

      RepeatCounter newCounter =  new RepeatCounter(userWord, userSentence);
      int wordInstances = newCounter.CountWordInSentence();
      
      Console.WriteLine("The word " + "'" + userWord + "'" + " appears " + wordInstances + " times in " + "'" + userSentence + "'");

      Console.WriteLine("Thanks for playing!");
    }
  }
}