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
  }
}