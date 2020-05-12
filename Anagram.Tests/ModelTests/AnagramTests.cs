using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams.Models;

namespace Anagrams.TestTools
{
  [TestClass]
  public class AnagramTests
  {
    [TestMethod]
    public void AnagramConstructor_CreatesInstanceOfAnagram_Anagram()
    {
      Anagram anagram = new Anagram("test");

      Assert.AreEqual(typeof(Anagram), anagram.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string word = "dear";
      Anagram anagram = new Anagram(word);

      string result = anagram.Word;

      Assert.AreEqual(word, result);
    }
  }
}