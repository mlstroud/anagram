
namespace Anagrams.Models
{
  public class Anagram
  {
    public string Word { get; set; }

    public Anagram(string word)
    {
      Word = word;
    }
  }
}