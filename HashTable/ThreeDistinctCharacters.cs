using System;
using System.Collections.Generic;

public class DistinctCharacters
{
  public static void Main(string[] args)
  {
    string str = "aabccd";
    DistinctCharacters word = new DistinctCharacters();
    Console.WriteLine(word.HasUptoThreeDistinctCharacters(str));
    Console.WriteLine(word.RemoveTopOneCharacters(str));
    Console.WriteLine(word.RemoveTopTwoCharacters(str));
  }

  Dictionary<char,int> dict = new Dictionary<char,int>();
  string word = "";
  char cha1;
  char cha2;
  int num1 = 0;
  int num2 = 0;

  public bool HasUptoThreeDistinctCharacters(string str)
  {
    for(int i = 0; i<str.Length; i++)
    {
      if(!dict.ContainsKey(str[i]))
      {
        word += str[i];
        dict[str[i]] = 1; 
      }
      else
      {
        dict[str[i]] += 1;
      }
    }
    for(int i = 0; i < word.Length; i++)
    {
      if(dict[word[i]] > num1){
        num1 = dict[word[i]];
        cha1 = word[i];
      }
      if(cha1 != word[i] && dict[word[i]] > num2)
      {
        num2 = dict[word[i]];
        cha2 = word[i];
      }
    }

    if(word.Length > 3)
    {
      return false;
    }
    else{
      return true;
    }

  }

  public string RemoveTopOneCharacters(string str)
  {
    if(HasUptoThreeDistinctCharacters(str))
    {
      return str;
    }
    
    string output = "";
    
    for(int i = 0; i < str.Length; i++)
    {
      if(str[i] != cha1)
      {
        output += str[i];
      }
    }
  
    return output;
  }

    public string RemoveTopTwoCharacters(string str)
  {
    if(HasUptoThreeDistinctCharacters(str))
    {
      return str;
    }
    
    string output = "";

    for(int i = 0; i < str.Length; i++)
    {
      if(str[i] != cha1 && str[i] != cha2)
      {
        output += str[i];
      }
    }
  
    return output;
  }
}
