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

      string result = Anagram.Word;

      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void SetWord_SetWord_String()
    {
      string word = "dear";
      Anagram anagram = new Anagram(word);

      string newWord = "pier";
      Anagram.Word = newWord;
      string result = Anagram.Word;

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
      Anagram.Add(word1);
      Anagram.Add(word2);
      List<string> wordList = new List<string> { word1, word2 };

      List<string> result = Anagram.GetList();

      CollectionAssert.AreEqual(wordList, result);
    }

    [TestMethod]
    public void SortWord_SortsWord_String()
    {
      string word = "dear";
      string sortedWord = "ader";
      Anagram anagram = new Anagram(word);

      Anagram.SortWord();
      string result = Anagram.SortedWord;

      Assert.AreEqual(sortedWord, result);
    }

    [TestMethod]
    public void SortList_SortsList_ListString()
    {
      string word1 = "dear";
      string word2 = "pier";
      string sortedWord1 = "ader";
      string sortedWord2 = "eipr";
      List<string> sortedList = new List<string> { sortedWord1, sortedWord2 };
      Anagram.Add(word1);
      Anagram.Add(word2);

      Anagram.SortList();
      List<string> result = Anagram.GetSortedList();

      CollectionAssert.AreEqual(sortedList, result);
    }

    [TestMethod]
    public void Match_ReturnsMatchingWords_ListString()
    {
      string word = "east";
      List<string> matches = new List<string> { "seat", "eats" };
      Anagram anagram = new Anagram(word);
      Anagram.Add("dear");
      Anagram.Add("seat");
      Anagram.Add("pier");
      Anagram.Add("eats");
      Anagram.Add("sand");

      Anagram.SortWord();
      Anagram.SortList();
      List<string> result = Anagram.GetAnagrams();

      CollectionAssert.AreEqual(matches, result);
    }
  }
}