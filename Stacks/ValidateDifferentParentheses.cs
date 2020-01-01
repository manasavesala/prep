using System;
using System.Collections.Generic;

public class ValidateDifferentParentheses{
  public static void Main(String[] args){
    Console.WriteLine(Validation("{(})"));
  }

  private static bool Validation(string str){

    Stack<char> s = new Stack<char>();

    for(int i = 0; i < str.Length; i++){

      if( str[i] == '(' || str[i] == '[' || str[i] == '{' )
      {
        s.Push(str[i]);
      }
      else if(s.Count == 0)
      {
         return false; 
      }
      else if(s.Peek() == '(' && str[i] == ')')
      {
        s.Pop();
      }
      else if(s.Peek() == '[' && str[i] == ']')
      {
        s.Pop();
      }
      else if(s.Peek() == '{' && str[i] == '}')
      {
        s.Pop();
      }
    }

    return s.Count == 0;
  }
}