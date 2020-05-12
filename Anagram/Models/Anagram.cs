using System;
using System.Collections.Generic;

namespace Anagrams.Models
{
  public class Anagram
  {
    public static string Word { get; set; }
    public static String SortedWord { get; set; }
    private static List<string> _wordList = new List<string>();
    private static List<string> _sortedWordList = new List<string>();

    public Anagram(string word)
    {
      Word = word;
    }

    public static void Add(string word)
    {
      _wordList.Add(word);
    }

    public static List<string> GetList()
    {
      return _wordList;
    }

    public static List<string> GetSortedList()
    {
      return _sortedWordList;
    }

    public static void ClearAll()
    {
      _wordList.Clear();
    }

    public static void SortWord()
    {
      char[] letters = Word.ToCharArray();
      Array.Sort(letters);

      SortedWord = string.Join("", letters);
    }

    public static void SortList()
    {
      for (int i = 0; i < _wordList.Count; i++)
      {
        char[] letters = _wordList[i].ToCharArray();
        Array.Sort(letters);
        _sortedWordList.Add(string.Join("", letters));
      }
    }

    public static List<string> GetAnagrams()
    {
      Anagram.SortWord();
      Anagram.SortList();

      return _wordList;
    }
  }
}