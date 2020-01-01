using System;
using System.Collections.Generic;

public class ChekingForloopInLL1{
  public static void Main(string[] args){
    int[] l1 = {1,2,3,4,4};
    Console.WriteLine(checkForLoop(l1));
  }

  public static bool checkForLoop(int[] li)
  {
    
    LinkedList<int> list = new LinkedList<int>(li);
    Dictionary<int,int> dist = new Dictionary<int,int>();
    LinkedListNode<int> current = list.First;

    while(current != null)
    {
      if(dist.ContainsKey(current.Value))
      {
        return true;
      }else
      {
        dist.Add(current.Value, 1);
      }
      current = current.Next;
    }
    return false;
  }
}