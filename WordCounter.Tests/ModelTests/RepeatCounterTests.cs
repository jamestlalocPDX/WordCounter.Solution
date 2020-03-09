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

    [TestMethod]
    public void GetSentence_ReturnsSentence_String()
    {
      string word = "the";
      string sentence = "the duck swims on the lake";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);

      string result = newCounter.Sentence;

      Assert.AreEqual(sentence, result);
    }

    [TestMethod]
    public void SetSentence_SetSentence_String()
    {
      string word = "the";
      string sentence = "the duck swims on the lake";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);

      string updatedSentence = "the duck sang on the lake";
      newCounter.Sentence = updatedSentence;
      string result = newCounter.Sentence;

      Assert.AreEqual(updatedSentence, result);
    }

    [TestMethod]
    public void GetCount_ReturnsCount_Integer()
    {
      string word = "the";
      string sentence = "the duck swims on the lake";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);

      int result = newCounter.Count;

      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void SetCount_SetCount_Integer()
    {
      string word = "the";
      string sentence = "the duck swims on the lake";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);

      int updatedCount = 5;
      newCounter.Count = updatedCount;
      int result = newCounter.Count;

      Assert.AreEqual(updatedCount, result);
    }

    [TestMethod]
    public void CountWordInSentence_CountWordInstancesInSentence_Integer()
    {
      string word = "the";
      string sentence = "the duck swims on the lake";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);

      int wordInstances = newCounter.CountWordInSentence();

      Assert.AreEqual(2, wordInstances);
    }

    [TestMethod]
    public void CountWordInSentence_IgnoreWordsWithPartialLetters_Integer()
    {
      string word = "the";
      string sentence = "the duck swims on the lake theater";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);

      int wordInstances = newCounter.CountWordInSentence();

      Assert.AreEqual(3, wordInstances);
    }
  }
}