using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    int[] l1 = {1,2,3};
    int[] l2 = {1,2,3};
    AddTwoLinkedLists(l1,l2);
  }
  public static void AddTwoLinkedLists(int[] l1, int[] l2){
    LinkedList<int> List1 = new LinkedList<int>(l1);
    LinkedList<int> List2 = new LinkedList<int>(l2);
    
    LinkedListNode<int> currentList1 = List1.First;
    LinkedListNode<int> currentList2 = List2.First;

    LinkedList<int> AddedList = new LinkedList<int>();
    while(currentList1 != null){
      AddedList.AddLast(currentList1.Value + currentList2.Value);
      currentList1 = currentList1.Next;
      currentList2 = currentList2.Next;
    }

    foreach(int i in AddedList){
      Console.WriteLine(i);
    }
  }
  
}