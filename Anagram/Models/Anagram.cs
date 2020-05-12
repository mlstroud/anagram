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
      _sortedWordList.Clear();
    }

    public static void SortWord()
    {
      char[] letters = Word.ToCharArray();
      Array.Sort(letters);

      SortedWord = string.Join("", letters);
    }

    public static void SortList()
    {
      foreach (string word in _wordList)
      {
        char[] letters = word.ToCharArray();
        Array.Sort(letters);
        _sortedWordList.Add(string.Join("", letters));
      }
    }

    public static List<string> GetAnagrams()
    {
      Anagram.SortWord();
      Anagram.SortList();
      List<string> matches = new List<string>();

      for (int i = 0; i < _sortedWordList.Count; i++)
      {
        if (SortedWord == _sortedWordList[i])
        {
          matches.Add(_wordList[i]);
        }
        else
        {
          bool allmatch = true;
          for (int j = 0; j < SortedWord.Length; j++)
          {
            if (!_sortedWordList[i].Contains(SortedWord[j]))
            {
              allmatch = false;
              break;
            }
          }

          if (allmatch)
          {
            matches.Add(_wordList[i]);
          }
        }
      }

      return matches;
    }
  }
}