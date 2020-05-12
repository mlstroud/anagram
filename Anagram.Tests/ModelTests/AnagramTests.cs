using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Anagrams.Models;

namespace Anagrams.TestTools
{
  [TestClass]
  public class AnagramTests : IDisposable
  {
    public void Dispose()
    {
      Anagram.ClearAll();
    }

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

    [TestMethod]
    public void SetWord_SetWord_String()
    {
      string word = "dear";
      Anagram anagram = new Anagram(word);

      string newWord = "pier";
      anagram.Word = newWord;
      string result = anagram.Word;

      Assert.AreEqual(newWord, result);
    }

    [TestMethod]
    public void GetList_ReturnsEmptyList_StringList()
    {
      List<string> newList = new List<string>();

      List<string> result = Anagram.GetList();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetList_ReturnsWords_StringList()
    {
      string word1 = "dear";
      string word2 = "pier";
      Anagram anagram1 = new Anagram(word1);
      Anagram anagram2 = new Anagram(word2);
      List<string> wordList = new List<string> { word1, word2 };

      List<string> result = Anagram.GetList();

      CollectionAssert.AreEqual(wordList, result);
    }
  }
}