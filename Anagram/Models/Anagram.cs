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

    public static List<string> GetList()
    {
      return _wordList;
    }
  }
}