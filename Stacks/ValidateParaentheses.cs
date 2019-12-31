using System;
using System.Collections;

 class ValidatingParaentheses{
  public static void Main(string[] args){
    Console.WriteLine(validate(""));
  }

  private static bool validate(string str){
    Stack s = new Stack();
      for(int i=0; i<str.Length; i++){
        if(str[i] == '('){
          s.Push(str[i]);
        }
        if(str[i] == ')'){
          try{
            s.Pop();
          }catch(Exception e){
            return false;
          }
        }
      }

      return s.Count == 0;
  }
  
}