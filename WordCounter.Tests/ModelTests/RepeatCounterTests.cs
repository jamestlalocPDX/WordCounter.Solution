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
      RepeatCounter newWord = new RepeatCounter("test");
      Assert.AreEqual(typeof(RepeatCounter), newWord.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string word = "the";
      RepeatCounter newWord = new RepeatCounter(word);
      string result = newWord.Word;
      Assert.AreEqual(word, result);
    }
  }
}