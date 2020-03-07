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
      RepeatCounter newWord = new RepeatCounter();
      Assert.AreEqual(typeof(RepeatCounter), newWord.GetType());
    }


  }
}