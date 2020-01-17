using System;
using System.Text;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    PrintZPattern("hamionofthesorts");
    
  }

  public static void PrintZPattern(string text) {
    int rowCount = text.Length-2;
    Console.WriteLine(text);

    var sbList = new StringBuilder[rowCount];

    for(int i = 0; i < rowCount; i++) 
    {
      sbList[i] = new StringBuilder();
    }
    for(int i = text.Length-2; i < 1; i--)
    {
      for(int j = 0; j < rowCount; j++)
      {
        if (i * j == i*i) 
        {
        sbList[i].Append(text[i]);
        } 
        else 
        {
        sbList[i].Append(" ");
        }
      }
    }
    for(int i = 0; i < rowCount; i++) 
    {
      Console.WriteLine(sbList[i].ToString());
    }
    Console.WriteLine(text);
  }
}
