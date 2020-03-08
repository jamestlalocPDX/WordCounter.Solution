using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.TestTools
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void RepeatCounterConstructor_CreatesAnInstanceOfWord_String()
    {
      RepeatCounter newCounter = new RepeatCounter("test");
      Assert.AreEqual(typeof(RepeatCounter), newCounter.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string word = "the";
      RepeatCounter newCounter = new RepeatCounter(word);

      string result = newCounter.Word;

      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void SetWord_SetWord_String()
    {
      string word = "the";
      RepeatCounter newCounter = new RepeatCounter(word);

      string updatedWord = "duck";
      newCounter.Word = updatedWord;
      string result = newCounter.Word;

      Assert.AreEqual(updatedWord, result);
    }
  }
}