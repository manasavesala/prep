using System;
using System.Collections.Generic;

public class MinStack {


  public static void Main(string[] args){
    MinStack minSt = new MinStack();
    minSt.Push(3);
    minSt.Push(-1);
    minSt.Pop();
    minSt.Pop();
    minSt.GetMin();
  }

  Stack<int> st = new Stack<int>();
  Stack<int> minStack = new Stack<int>();

  public void Push(int x)
  {
      st.Push(x);
      if(minStack.Count == 0)
      {
        minStack.Push(x);
      }
      else if(x < minStack.Peek()){
          minStack.Push(x);
      }
  }

  public void Pop()
  {
      if(minStack.Peek() == st.Peek())
      {
          minStack.Pop();    
      }
      st.Pop();
  }

  public void Peek()
  {
      if(minStack.Count < 0)
      {
          throw new Exception("Empty stack!");
      }
      else
      {
          Console.WriteLine(minStack.Peek());
      }
  }

  public void GetMin()
  {
      Console.WriteLine(minStack.Peek());
  }
}