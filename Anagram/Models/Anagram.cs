using System;
using System.Collections.Generic;

namespace Anagrams.Models
{
  public class Anagram
  {
    public string Word { get; set; }
    private static List<string> _wordList = new List<string>();

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

    public static void ClearAll()
    {
      _wordList.Clear();
    }

    public void SortWord()
    {
      char[] letters = Word.ToCharArray();
      Array.Sort(letters);

      Word = string.Join("", letters);
    }

    public static void SortList()
    {
      for (int i = 0; i < _wordList.Count; i++)
      {
        char[] letters = _wordList[i].ToCharArray();
        Array.Sort(letters);
        _wordList[i] = string.Join("", letters);
      }
    }
  }
}