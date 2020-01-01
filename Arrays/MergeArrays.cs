using System;
using System.Collections.Generic;

class MergeSortedArrays 
{
  public static void Main(String[] args)
  {
    int[] a1 = {2,4,6,9,10};
    int[] a2 = {1,3,5,7,8};
    var a3 = MergeTwoSortedArrays(a1,a2);
    foreach(int a in a3) {
      Console.Write(a + " ");
    }

    Console.WriteLine();
  }

  private static int[] MergeTwoSortedArrays(int[] a1, int[] a2)
  {
    int a = 0;
    int b = 0;
    int j = 0;

    int[] arr = new int[a1.Length + a2.Length];

    for(int i = 0; i < arr.Length; i++){
      if(a1[a] < a2[b])
      {
        arr[i] = a1[a];
        a++;
      }
      else
      {
        arr[i] = a2[b];
        b++;
      }
      
      j = i+1;
      if(a == a1.Length || b == a2.Length)
      {
        i = arr.Length;
      }

    }

    Console.WriteLine(String.Format("j = {0}, a = {1}, b = {2}", j, a, b));
    if(a == a1.Length)
    {
      for(int i = j; i < arr.Length; i++){
        arr[i] = a2[b];
        b++;
      }
    }
    else if(b == a2.Length)
    {
      for(int i = j; i < arr.Length; i++){
        arr[i] = a1[a];
        a++;
      }
    }

    return arr;

  }
}
