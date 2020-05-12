using System;
using System.Collections.Generic;
using Anagrams.Models;

namespace Anagrams
{
  public class Program
  {
    public static void Main()
    {
      string userInput = "";
      List<string> anagrams;
      userInput = PromptUser();
      Anagram.Word = userInput;
      GatherWordList();
      anagrams = Anagram.GetAnagrams();
      DisplayAnagrams(anagrams);
    }

    public static string PromptUser()
    {
      Console.WriteLine("Enter a word to start");
      Console.WriteLine("---------------------");
      string input = Console.ReadLine();
      return input.ToLower();
    }

    public static void GatherWordList()
    {
      string userInput = "";
      Console.WriteLine("Enter words one at a time to compare against. Enter 'Q' when done.");

      while (userInput != "q")
      {
        userInput = Console.ReadLine().ToLower();
        Anagram.Add(userInput);
      }
    }

    public static void DisplayAnagrams(List<string> anagrams)
    {
      if (anagrams.Count == 0)
      {
        Console.WriteLine("There were no anagrams.");
      }
      else
      {
        Console.WriteLine("Anagrams for " + Anagram.Word);
        for (int i = 0; i < anagrams.Count; i++)
        {
          Console.WriteLine((i + 1) + ". " + anagrams[i]);
        }
      }
    }
  }
}