using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.TestTools
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void wordCheck_ReturnsAString_string()
    {
      RepeatCounter newWord = new RepeatCounter("word");
      Assert.AreEqual("word", newWord.wordCheck());
    }
  }
}