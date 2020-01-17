using System;
using System.Collections;

 class ValidatingParaentheses{
  public static void Main(string[] args){
    Console.WriteLine(validate("()"));
    Console.WriteLine(validate(null));

  }
/*Given a string with parentheses, return "true" if string is fully formed;
ex: input:"()()"
    output: true
    input:"))";
    output:false;
*/
  private static bool validate(string str){
    // no reason ;
    Stack s = new Stack();
    if(str == null){
      return false;
    }
    for(int i=0; i<str.Length; i++)
    {
      if(str[i] == '(')
      {
        s.Push(str[i]);
      }
      if(str[i] == ')')
      {
        try
        {
          s.Pop();
        }
        catch(InvalidOperationException)
        {
          return false;
        }
      }
    }
  //It says if a stack is empty or not. if count == 0 if returns true because stack is empty.
      return s.Count == 0;
  }
  
}