using System;
using System.Collections.Generic;

public class ImplementStackUsingLinkedList
{
  public static void Main(string[] args)
  {
    ImplementStackUsingLinkedList stack = new ImplementStackUsingLinkedList();
    stack.Push(1);
    stack.Push(2);
    stack.Pop();
    stack.Print();
  }

  LinkedList<int> list = new LinkedList<int>(); 
  public void Push(int val){
    if(list.Count == 0)
    {
      list.AddFirst(val);
    }
    else
    {
      list.AddFirst(val);
    }
  }

  public void Pop(){
    if(list.Count == 0)
    {
      Console.WriteLine("No elements to remove in the stack");
    }
    else
    {
      list.RemoveFirst();
    }
  }

  public void Peek()
  {
    if(list.Count == 0)
    {
      Console.WriteLine("No elements in the stack");
    }
    else
    {
      Console.WriteLine(list.First.Value);
    }
  }

  public void Print()
  {
    foreach(int i in list)
    {
      Console.WriteLine(i);
    }
  }

}
   