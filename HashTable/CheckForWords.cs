using System;
using System.Collections.Generic;

public class CheckForWords{
  public static void Main(string[] args)
  {
    CheckForWords nW = new CheckForWords();

    char[] letters = {'c', 'a', 'r', 'c', 'a', 't'};
    string[] words = {"cat","carc"};
    Console.WriteLine(nW.AreWordsFormedFromLetters(letters, words));
  }

  
  private bool AreCharactersOfWordInDictonary(string word, Dictionary<char, int> dict)
    {
      for(int i = 0; i < word.Length; i++)
      {
        if(dict.ContainsKey(word[i]))
        {
          dict[word[i]] -= 1;
        }
        else
        {
          return false;
        }
        if(dict[word[i]]==0){
          dict.Remove(word[i]);
        } 
      }
      return true;
  }

  public bool AreWordsFormedFromLetters(char[] letters, string[] words)
  {
    Dictionary<char, int> dict = new Dictionary<char,int>();

    for(int i = 0; i < letters.Length; i++)
    {
      if(dict.ContainsKey(letters[i]))
      {
        dict[letters[i]] += 1;
      }
      else
      {
        dict[letters[i]] = 1;
      }
    }
    
    for(int i = 0; i < words.Length; i++)
    {
      if(!AreCharactersOfWordInDictonary(words[i], dict))
      {
        return false;
      }
    }
    
    return true;

  }
}