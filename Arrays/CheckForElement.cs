using System;

class CheckForelement{
  public static void Main(string[] args)
  {
    int[] array = {1,2,3,5,7};
    Console.WriteLine(checkValue(array, 5));
  }

  public static bool checkValue(int[] array, int k)
  {
    for(int i = 0; i < array.Length; i++){
      if(array[i] == k)
      {
        return true;
      }
    }
    return false;
  } 
}