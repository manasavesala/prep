using System;
using System.Collections.Generic;

public class ImplementQueueUsingStack
{
  public static void Main(string[] args)
  {
    ImplementQueueUsingStack qu = new ImplementQueueUsingStack();
    // qu.QueueStack(1);
    qu.DequeueStack();
  }
  // 1. Use a constructor
  Stack<int> queueStack;
  Stack<int> dequeueStack;

  public ImplementQueueUsingStack()
  {
    queueStack = new Stack<int>();
    dequeueStack = new Stack<int>();
  }

  public void QueueStack(int val){
    queueStack.Push(val);
  }
  
  public void DequeueStack()
  {
    if (dequeueStack.Count == 0)
    {
      while(queueStack.Count != 0)
      {
        dequeueStack.Push(queueStack.Peek());
        queueStack.Pop();
      }
    }
    
    if (dequeueStack.Count == 0)
    {
      throw new InvalidOperationException("Queue empty");
    }
    dequeueStack.Pop();
  }
}